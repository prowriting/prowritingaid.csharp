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
        public const int DefaultMonitoringTimeStepInMs = 1000;

        //delay between GetResult requests
        private readonly int _monitoringTimeStepInMs;

        private readonly TInitiator _initiator;

        private readonly TGetter _getter;

        protected AsyncApiBase(
            TInitiator initiator,
            TGetter getter,
            int monitoringTimeStepInMs = DefaultMonitoringTimeStepInMs)
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
            var response = _initiator.PostWithHttpInfo(request);
            if (response.Data?.Result != null)
            {
                return new ApiResponse<TResponse>(response.StatusCode, response.Headers, response.Data?.Result);
            }
            if (string.IsNullOrEmpty(response.Data?.TaskId))
            {
                throw new ApiException(422, "Unidentified error: can't process async request;");
            }
            var iterationIdx = 0;
            var maxIterations = GetMaxNumberOfIterations();
            while (response?.Data?.Result == null && iterationIdx < maxIterations)
            {
                Thread.Sleep(_monitoringTimeStepInMs);
                response = _getter.GetResultWithHttpInfo(response?.Data?.TaskId, request.Credentials);
                iterationIdx++;
            }
            if (response?.Data?.Result == null)
            {
                throw new ApiException(
                    408,
                    $@"Request timeout: wasn't able to get result in {Configuration.Timeout} ms");
            }
            return new ApiResponse<TResponse>(response.StatusCode, response.Headers, response.Data.Result);
        }

        protected async Task<ApiResponse<TResponse>> PostAsyncWithHttpInfo(
            TRequest request)
        {
            var response = await _initiator.PostAsyncWithHttpInfo(request);
            if (response.Data?.Result != null)
            {
                return new ApiResponse<TResponse>(response.StatusCode, response.Headers, response.Data?.Result);
            }
            if (string.IsNullOrEmpty(response.Data?.TaskId))
            {
                throw new ApiException(422, "Unidentified error: can't process async request;");
            }
            var iterationIdx = 0;
            var maxIterations = GetMaxNumberOfIterations();
            while (response?.Data?.Result == null && iterationIdx < maxIterations)
            {
                await Task.Delay(_monitoringTimeStepInMs);
                response = await _getter.GetResultAsyncWithHttpInfo(response?.Data?.TaskId, request.Credentials);
                iterationIdx++;
            }
            if (response?.Data?.Result == null)
            {
                throw new ApiException(
                    408,
                    $@"Request timeout: wasn't able to get result in {Configuration.Timeout} ms");
            }
            return new ApiResponse<TResponse>(response.StatusCode, response.Headers, response.Data.Result);
        }
    }


    public interface IAsyncApiGetter<TResponse> : IApiAccessor
    {
        ApiResponse<IAsyncResponse<TResponse>> GetResultWithHttpInfo(string taskId, RequestCredentials credentials);

        Task<ApiResponse<IAsyncResponse<TResponse>>> GetResultAsyncWithHttpInfo(
            string taskId,
            RequestCredentials credentials);
    }

    public interface IAsyncApiInitiator<TRequest, TResponse> : IApiAccessor
        where TRequest : AnalysisRequestBase
    {
        ApiResponse<IAsyncResponse<TResponse>> PostWithHttpInfo(TRequest request);
        Task<ApiResponse<IAsyncResponse<TResponse>>> PostAsyncWithHttpInfo(TRequest request);
    }
}