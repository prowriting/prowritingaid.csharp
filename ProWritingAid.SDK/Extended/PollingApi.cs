using System;
using System.Threading;
using System.Threading.Tasks;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model.Async;
using System.Diagnostics;

namespace ProWritingAid.SDK.Api.Async
{
    public interface IAsyncApi<TRequest, TResponse, TWrapper> : IApiAccessor
        where TRequest : class
        where TWrapper : IAsyncResponse<TResponse>
    {
        ApiResponse<TWrapper> GetWithHttpInfo(string taskId);
        Task<ApiResponse<TWrapper>> GetAsyncWithHttpInfo(string taskId);
        ApiResponse<TWrapper> PostWithHttpInfo(TRequest request);
        Task<ApiResponse<TWrapper>> PostAsyncWithHttpInfo(TRequest request);
    }

    public abstract class PollingApi<TRequest, TResponse, TWrapper> : ApiHeaders, IApiAccessor
        where TRequest : class
        where TResponse : class
        where TWrapper : IAsyncResponse<TResponse>
    {
        public const int DefaultMonitoringTimeStepInMs = 1000;

        //delay between GetResult requests
        private readonly int _monitoringTimeStepInMs;

        private readonly IAsyncApi<TRequest, TResponse, TWrapper> _api;

        protected PollingApi(
            IAsyncApi<TRequest, TResponse, TWrapper> api,
            int monitoringTimeStepInMs = DefaultMonitoringTimeStepInMs)
        {
            _api = api;
            _monitoringTimeStepInMs = monitoringTimeStepInMs;
        }

        public Configuration Configuration { get { return _api.Configuration; } set { _api.Configuration = value; } }

        public string GetBasePath()
        {
            return _api.GetBasePath();
        }

        public ExceptionFactory ExceptionFactory
        {
            get { return _api.ExceptionFactory; }
            set { _api.ExceptionFactory = value; }
        }

        private int GetMaxNumberOfIterations()
        {
            return Math.Max(1, Configuration.Timeout / _monitoringTimeStepInMs);
        }

        public TResponse Post(TRequest request)
        {
            var localVarResponse = PostWithHttpInfo(request);
            return localVarResponse.Data;
        }

        public ApiResponse<TResponse> PostWithHttpInfo(
            TRequest request)
        {
            var response = _api.PostWithHttpInfo(request);
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
            var watch = Stopwatch.StartNew();
            while (response?.Data?.Result == null && iterationIdx < maxIterations)
            {
                Thread.Sleep(_monitoringTimeStepInMs);
                response = _api.GetWithHttpInfo(response?.Data?.TaskId);
                iterationIdx++;
            }
            if (response?.Data?.Result == null)
            {
                throw new ApiException(
                    408,
                    $@"Request timeout: wasn't able to get result in {watch.ElapsedMilliseconds} ms");
            }
            return new ApiResponse<TResponse>(response.StatusCode, response.Headers, response.Data.Result);
        }

        public async Task<TResponse> PostAsync(TRequest request)
        {
            var localVarResponse = await PostAsyncWithHttpInfo(request);
            return localVarResponse.Data;
        }

        public async Task<ApiResponse<TResponse>> PostAsyncWithHttpInfo(
            TRequest request)
        {
            var response = await _api.PostAsyncWithHttpInfo(request);
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
            var watch = Stopwatch.StartNew();
            while (response?.Data?.Result == null && iterationIdx < maxIterations)
            {
                await Task.Delay(_monitoringTimeStepInMs);
                response = await _api.GetAsyncWithHttpInfo(response?.Data?.TaskId);
                iterationIdx++;
            }
            if (response?.Data?.Result == null)
            {
                throw new ApiException(
                    408,
                    $@"Request timeout: wasn't able to get result in {watch.ElapsedMilliseconds} ms");
            }
            return new ApiResponse<TResponse>(response.StatusCode, response.Headers, response.Data.Result);
        }
    }
}