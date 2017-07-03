using System;
using System.Threading.Tasks;
using ProWritingAid.SDK.Api.Async;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model;
using ProWritingAid.SDK.Model.Async;

namespace ProWritingAid.SDK.Api
{
    //Contextual thesaurus

    public partial class AsyncContextualThesaurusApi : IAsyncApiInitiator<ContextualThesaurusRequest,
        ContextualThesaurusResponse>
    {
        public ApiResponse<IAsyncResponse<ContextualThesaurusResponse>> PostWithHttpInfo(
            ContextualThesaurusRequest request)
        {
            var res = AsyncContextualThesaurusPostWithHttpInfo(request);
            return new ApiResponse<IAsyncResponse<ContextualThesaurusResponse>>(res.StatusCode, res.Headers, res.Data);
        }

        public async Task<ApiResponse<IAsyncResponse<ContextualThesaurusResponse>>> PostAsyncWithHttpInfo(
            ContextualThesaurusRequest request)
        {
            var res = await AsyncContextualThesaurusPostAsyncWithHttpInfo(request);
            return new ApiResponse<IAsyncResponse<ContextualThesaurusResponse>>(res.StatusCode, res.Headers, res.Data);
        }
    }

    public partial class AsyncContextualThesaurusResultApi : IAsyncApiGetter<ContextualThesaurusResponse>
    {
        public ApiResponse<ContextualThesaurusResponse> GetResultWithHttpInfo(
            string taskId,
            RequestCredentials credentials)
        {
            return AsyncContextualThesaurusResultGetResultWithHttpInfo(taskId, credentials);
        }

        public async Task<ApiResponse<ContextualThesaurusResponse>> GetResultAsyncWithHttpInfo(
            string taskId,
            RequestCredentials credentials)
        {
            return await AsyncContextualThesaurusResultGetResultAsyncWithHttpInfo(taskId, credentials);
        }
    }
    
    //Word cloud
    public partial class AsyncWordCloudApi : IAsyncApiInitiator<WordCloudRequest,
        WordCloudResponse>
    {
        public ApiResponse<IAsyncResponse<WordCloudResponse>> PostWithHttpInfo(
            WordCloudRequest request)
        {
            var res = AsyncWordCloudPostWithHttpInfo(request);
            return new ApiResponse<IAsyncResponse<WordCloudResponse>>(res.StatusCode, res.Headers, res.Data);
        }

        public async Task<ApiResponse<IAsyncResponse<WordCloudResponse>>> PostAsyncWithHttpInfo(
            WordCloudRequest request)
        {
            var res = await AsyncWordCloudPostAsyncWithHttpInfo(request);
            return new ApiResponse<IAsyncResponse<WordCloudResponse>>(res.StatusCode, res.Headers, res.Data);
        }
    }

    public partial class AsyncWordCloudResultApi : IAsyncApiGetter<WordCloudResponse>
    {
        public ApiResponse<WordCloudResponse> GetResultWithHttpInfo(
            string taskId,
            RequestCredentials credentials)
        {
            return AsyncWordCloudResultGetResultWithHttpInfo(taskId, credentials);
        }

        public async Task<ApiResponse<WordCloudResponse>> GetResultAsyncWithHttpInfo(
            string taskId,
            RequestCredentials credentials)
        {
            return await AsyncWordCloudResultGetResultAsyncWithHttpInfo(taskId, credentials);
        }
    }

    //Text
    public partial class AsyncTextApi : IAsyncApiInitiator<TextAnalysisRequest,
        TextAnalysisResponse>
    {
        public ApiResponse<IAsyncResponse<TextAnalysisResponse>> PostWithHttpInfo(
            TextAnalysisRequest request)
        {
            var res = AsyncTextPostWithHttpInfo(request);
            return new ApiResponse<IAsyncResponse<TextAnalysisResponse>>(res.StatusCode, res.Headers, res.Data);
        }

        public async Task<ApiResponse<IAsyncResponse<TextAnalysisResponse>>> PostAsyncWithHttpInfo(
            TextAnalysisRequest request)
        {
            var res = await AsyncTextPostAsyncWithHttpInfo(request);
            return new ApiResponse<IAsyncResponse<TextAnalysisResponse>>(res.StatusCode, res.Headers, res.Data);
        }
    }

    public partial class AsyncTextResultApi : IAsyncApiGetter<TextAnalysisResponse>
    {
        public ApiResponse<TextAnalysisResponse> GetResultWithHttpInfo(
            string taskId,
            RequestCredentials credentials)
        {
            return AsyncTextResultGetResultWithHttpInfo(taskId, credentials);
        }

        public async Task<ApiResponse<TextAnalysisResponse>> GetResultAsyncWithHttpInfo(
            string taskId,
            RequestCredentials credentials)
        {
            return await AsyncTextResultGetResultAsyncWithHttpInfo(taskId, credentials);
        }
    }

    //Html
    public partial class AsyncHtmlApi : IAsyncApiInitiator<HtmlAnalysisRequest,
        HtmlAnalysisResponse>
    {
        public ApiResponse<IAsyncResponse<HtmlAnalysisResponse>> PostWithHttpInfo(
            HtmlAnalysisRequest request)
        {
            var res = AsyncHtmlPostWithHttpInfo(request);
            return new ApiResponse<IAsyncResponse<HtmlAnalysisResponse>>(res.StatusCode, res.Headers, res.Data);
        }

        public async Task<ApiResponse<IAsyncResponse<HtmlAnalysisResponse>>> PostAsyncWithHttpInfo(
            HtmlAnalysisRequest request)
        {
            var res = await AsyncHtmlPostAsyncWithHttpInfo(request);
            return new ApiResponse<IAsyncResponse<HtmlAnalysisResponse>>(res.StatusCode, res.Headers, res.Data);
        }
    }

    public partial class AsyncHtmlResultApi : IAsyncApiGetter<HtmlAnalysisResponse>
    {
        public ApiResponse<HtmlAnalysisResponse> GetResultWithHttpInfo(
            string taskId,
            RequestCredentials credentials)
        {
            return AsyncHtmlResultGetResultWithHttpInfo(taskId, credentials);
        }

        public async Task<ApiResponse<HtmlAnalysisResponse>> GetResultAsyncWithHttpInfo(
            string taskId,
            RequestCredentials credentials)
        {
            return await AsyncHtmlResultGetResultAsyncWithHttpInfo(taskId, credentials);
        }
    }
    
    //Summary
    public partial class AsyncSummaryApi : IAsyncApiInitiator<SummaryAnalysisRequest,
        SummaryAnalysisResponse>
    {
        public ApiResponse<IAsyncResponse<SummaryAnalysisResponse>> PostWithHttpInfo(
            SummaryAnalysisRequest request)
        {
            var res = AsyncSummaryPostWithHttpInfo(request);
            return new ApiResponse<IAsyncResponse<SummaryAnalysisResponse>>(res.StatusCode, res.Headers, res.Data);
        }

        public async Task<ApiResponse<IAsyncResponse<SummaryAnalysisResponse>>> PostAsyncWithHttpInfo(
            SummaryAnalysisRequest request)
        {
            var res = await AsyncSummaryPostAsyncWithHttpInfo(request);
            return new ApiResponse<IAsyncResponse<SummaryAnalysisResponse>>(res.StatusCode, res.Headers, res.Data);
        }
    }

    public partial class AsyncSummaryResultApi : IAsyncApiGetter<SummaryAnalysisResponse>
    {
        public ApiResponse<SummaryAnalysisResponse> GetResultWithHttpInfo(
            string taskId,
            RequestCredentials credentials)
        {
            return AsyncSummaryResultGetResultWithHttpInfo(taskId, credentials);
        }

        public async Task<ApiResponse<SummaryAnalysisResponse>> GetResultAsyncWithHttpInfo(
            string taskId,
            RequestCredentials credentials)
        {
            return await AsyncSummaryResultGetResultAsyncWithHttpInfo(taskId, credentials);
        }
    }
}