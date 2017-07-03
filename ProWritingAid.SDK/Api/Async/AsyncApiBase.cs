using System;
using System.Threading;
using System.Threading.Tasks;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model;
using ProWritingAid.SDK.Model.Async;

namespace ProWritingAid.SDK.Api.Async
{
    public abstract class AsyncApiBase<TRequest, TResponse, TInitiator, TGetter> : ApiBase, IApiAccessor
        where TRequest : AnalysisRequestBase
        where TResponse : class
        where TInitiator : IAsyncApiInitiator<TRequest, TResponse>
        where TGetter : IAsyncApiGetter<TResponse>
    {
        public const int DefaultMonitoringTimeStepInMs = 500;
        
        //delay between GetResult requests
        private readonly int _monitoringTimeStepInMs;

        private readonly TInitiator _initiator;

        private readonly TGetter _getter;

        protected AsyncApiBase(TInitiator initiator, TGetter getter, int monitoringTimeStepInMs = DefaultMonitoringTimeStepInMs)
        {
            _initiator = initiator;
            _getter = getter;
            _monitoringTimeStepInMs = monitoringTimeStepInMs;
        }

        public Configuration Configuration
        {
            get { return _initiator.Configuration; }
            set { _initiator.Configuration = value; }
        }

        public string GetBasePath()
        {
            return _initiator.GetBasePath();
        }

        public ExceptionFactory ExceptionFactory
        {
            get { return _initiator.ExceptionFactory; }
            set { _initiator.ExceptionFactory = value; }
        }

        private int GetMaxNumberOfIterations()
        {
            return Math.Max(1, Configuration.Timeout / _monitoringTimeStepInMs);
        }

        protected ApiResponse<TResponse> PostWithHttpInfo(
            TRequest request)
        {
            var asyncTask = _initiator.PostWithHttpInfo(request);
            var response = new ApiResponse<TResponse>(
                asyncTask.StatusCode,
                asyncTask.Headers,
                asyncTask.Data?.Result);
            if (asyncTask.Data?.Result != null)
            {
                return response;
            }
            var taskId = asyncTask?.Data?.TaskId;
            if (string.IsNullOrEmpty(taskId))
            {
                throw new ApiException(422, "Unidentified error: can't process async request;");
            }
            var iterationIdx = 0;
            var maxIterations = GetMaxNumberOfIterations();
            while (response?.Data == null && iterationIdx < maxIterations)
            {
                Thread.Sleep(_monitoringTimeStepInMs);
                response = _getter.GetResultWithHttpInfo(taskId, request.Credentials);
                iterationIdx++;
            }
            if (response?.Data == null)
            {
                throw new ApiException(
                    408,
                    $@"Request timeout: wasn't able to get result in {Configuration.Timeout} ms");
            }
            return response;
        }

        protected async Task<ApiResponse<TResponse>> PostAsyncWithHttpInfo(
            TRequest request)
        {
            var asyncTask = await _initiator.PostAsyncWithHttpInfo(request);
            var response = new ApiResponse<TResponse>(
                asyncTask.StatusCode,
                asyncTask.Headers,
                asyncTask.Data?.Result);
            if (asyncTask.Data?.Result != null)
            {
                return response;
            }
            var taskId = asyncTask?.Data?.TaskId;
            if (string.IsNullOrEmpty(taskId))
            {
                throw new ApiException(422, "Unidentified error: can't process async request;");
            }
            var iterationIdx = 0;
            var maxIterations = GetMaxNumberOfIterations();
            while (response?.Data == null && iterationIdx < maxIterations)
            {
                await Task.Delay(_monitoringTimeStepInMs);
                response = await _getter.GetResultAsyncWithHttpInfo(taskId, request.Credentials);
                iterationIdx++;
            }
            if (response?.Data == null)
            {
                throw new ApiException(
                    408,
                    $@"Request timeout: wasn't able to get result in {Configuration.Timeout} ms");
            }
            return response;
        }
    }

    public interface IAsyncApiGetter<TResponse> : IApiAccessor
    {
        ApiResponse<TResponse> GetResultWithHttpInfo(string taskId, RequestCredentials credentials);
        Task<ApiResponse<TResponse>> GetResultAsyncWithHttpInfo(string taskId, RequestCredentials credentials);
    }

    public interface IAsyncApiInitiator<TRequest, TResponse> : IApiAccessor
        where TRequest : AnalysisRequestBase

    {
        ApiResponse<IAsyncResponse<TResponse>> PostWithHttpInfo(TRequest request);
        Task<ApiResponse<IAsyncResponse<TResponse>>> PostAsyncWithHttpInfo(TRequest request);
    }
}