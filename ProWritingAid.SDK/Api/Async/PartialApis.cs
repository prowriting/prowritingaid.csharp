using System;
using System.Threading.Tasks;
using ProWritingAid.SDK.Api.Async;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model;
using ProWritingAid.SDK.Model.Async;

// ReSharper disable once CheckNamespace
namespace ProWritingAid.SDK.Api
{
    internal static class Tools
    {
        public static ApiResponse<IAsyncResponse<TData>> Convert<TData, TResponse>(ApiResponse<TResponse> response)
            where TResponse : IAsyncResponse<TData>
        {
            return new ApiResponse<IAsyncResponse<TData>>(response.StatusCode, response.Headers, response.Data);
        }
    }

    //Contextual thesaurus

    public partial class AsyncContextualThesaurusApi : IAsyncApiInitiator<ContextualThesaurusRequest,
        ContextualThesaurusResponse>
    {
        public ApiResponse<IAsyncResponse<ContextualThesaurusResponse>> PostWithHttpInfo(
            ContextualThesaurusRequest request)
        {
            return Tools.Convert<ContextualThesaurusResponse, AsyncResponseContextualThesaurusResponse>(
                AsyncContextualThesaurusPostWithHttpInfo(request));
        }

        public async Task<ApiResponse<IAsyncResponse<ContextualThesaurusResponse>>> PostAsyncWithHttpInfo(
            ContextualThesaurusRequest request)
        {
            return Tools.Convert<ContextualThesaurusResponse, AsyncResponseContextualThesaurusResponse>(
                await AsyncContextualThesaurusPostAsyncWithHttpInfo(request));
        }
    }

    public partial class AsyncContextualThesaurusResultApi : IAsyncApiGetter<ContextualThesaurusResponse>
    {
        public ApiResponse<IAsyncResponse<ContextualThesaurusResponse>> GetResultWithHttpInfo(
            string taskId,
            RequestCredentials credentials)
        {
            return Tools.Convert<ContextualThesaurusResponse, AsyncResponseContextualThesaurusResponse>(
                AsyncContextualThesaurusResultGetResultWithHttpInfo(taskId, credentials));
        }

        public async Task<ApiResponse<IAsyncResponse<ContextualThesaurusResponse>>> GetResultAsyncWithHttpInfo(
            string taskId,
            RequestCredentials credentials)
        {
            return Tools.Convert<ContextualThesaurusResponse, AsyncResponseContextualThesaurusResponse>(
                await AsyncContextualThesaurusResultGetResultAsyncWithHttpInfo(taskId, credentials));
        }
    }

    //Word cloud
    public partial class AsyncWordCloudApi : IAsyncApiInitiator<WordCloudRequest,
        WordCloudResponse>
    {
        public ApiResponse<IAsyncResponse<WordCloudResponse>> PostWithHttpInfo(
            WordCloudRequest request)
        {
            return Tools.Convert<WordCloudResponse, AsyncResponseWordCloudResponse>(
                AsyncWordCloudPostWithHttpInfo(request));
        }

        public async Task<ApiResponse<IAsyncResponse<WordCloudResponse>>> PostAsyncWithHttpInfo(
            WordCloudRequest request)
        {
            return Tools.Convert<WordCloudResponse, AsyncResponseWordCloudResponse>(
                await AsyncWordCloudPostAsyncWithHttpInfo(request));
        }
    }

    public partial class AsyncWordCloudResultApi : IAsyncApiGetter<WordCloudResponse>
    {
        public ApiResponse<IAsyncResponse<WordCloudResponse>> GetResultWithHttpInfo(
            string taskId,
            RequestCredentials credentials)
        {
            return Tools.Convert<WordCloudResponse, AsyncResponseWordCloudResponse>(
                AsyncWordCloudResultGetResultWithHttpInfo(taskId, credentials));
        }

        public async Task<ApiResponse<IAsyncResponse<WordCloudResponse>>> GetResultAsyncWithHttpInfo(
            string taskId,
            RequestCredentials credentials)
        {
            return Tools.Convert<WordCloudResponse, AsyncResponseWordCloudResponse>(
                await AsyncWordCloudResultGetResultAsyncWithHttpInfo(taskId, credentials));
        }
    }

    //Text
    public partial class AsyncTextApi : IAsyncApiInitiator<TextAnalysisRequest,
        TextAnalysisResponse>
    {
        public ApiResponse<IAsyncResponse<TextAnalysisResponse>> PostWithHttpInfo(
            TextAnalysisRequest request)
        {
            return Tools.Convert<TextAnalysisResponse, AsyncResponseTextAnalysisResponse>(
                AsyncTextPostWithHttpInfo(request));
        }

        public async Task<ApiResponse<IAsyncResponse<TextAnalysisResponse>>> PostAsyncWithHttpInfo(
            TextAnalysisRequest request)
        {
            return Tools.Convert<TextAnalysisResponse, AsyncResponseTextAnalysisResponse>(
                await AsyncTextPostAsyncWithHttpInfo(request));
        }
    }

    public partial class AsyncTextResultApi : IAsyncApiGetter<TextAnalysisResponse>
    {
        public ApiResponse<IAsyncResponse<TextAnalysisResponse>> GetResultWithHttpInfo(
            string taskId,
            RequestCredentials credentials)
        {
            return Tools.Convert<TextAnalysisResponse, AsyncResponseTextAnalysisResponse>(
                AsyncTextResultGetResultWithHttpInfo(taskId, credentials));
        }

        public async Task<ApiResponse<IAsyncResponse<TextAnalysisResponse>>> GetResultAsyncWithHttpInfo(
            string taskId,
            RequestCredentials credentials)
        {
            return Tools.Convert<TextAnalysisResponse, AsyncResponseTextAnalysisResponse>(
                await AsyncTextResultGetResultAsyncWithHttpInfo(taskId, credentials));
        }
    }

    //Html
    public partial class AsyncHtmlApi : IAsyncApiInitiator<HtmlAnalysisRequest,
        HtmlAnalysisResponse>
    {
        public ApiResponse<IAsyncResponse<HtmlAnalysisResponse>> PostWithHttpInfo(
            HtmlAnalysisRequest request)
        {
            return Tools.Convert<HtmlAnalysisResponse, AsyncResponseHtmlAnalysisResponse>(
                AsyncHtmlPostWithHttpInfo(request));
        }

        public async Task<ApiResponse<IAsyncResponse<HtmlAnalysisResponse>>> PostAsyncWithHttpInfo(
            HtmlAnalysisRequest request)
        {
            return Tools.Convert<HtmlAnalysisResponse, AsyncResponseHtmlAnalysisResponse>(
                await AsyncHtmlPostAsyncWithHttpInfo(request));
        }
    }

    public partial class AsyncHtmlResultApi : IAsyncApiGetter<HtmlAnalysisResponse>
    {
        public ApiResponse<IAsyncResponse<HtmlAnalysisResponse>> GetResultWithHttpInfo(
            string taskId,
            RequestCredentials credentials)
        {
            return Tools.Convert<HtmlAnalysisResponse, AsyncResponseHtmlAnalysisResponse>(
                AsyncHtmlResultGetResultWithHttpInfo(taskId, credentials));
        }

        public async Task<ApiResponse<IAsyncResponse<HtmlAnalysisResponse>>> GetResultAsyncWithHttpInfo(
            string taskId,
            RequestCredentials credentials)
        {
            return Tools.Convert<HtmlAnalysisResponse, AsyncResponseHtmlAnalysisResponse>(
                await AsyncHtmlResultGetResultAsyncWithHttpInfo(taskId, credentials));
        }
    }

    //Summary
    public partial class AsyncSummaryApi : IAsyncApiInitiator<SummaryAnalysisRequest,
        SummaryAnalysisResponse>
    {
        public ApiResponse<IAsyncResponse<SummaryAnalysisResponse>> PostWithHttpInfo(
            SummaryAnalysisRequest request)
        {
            return Tools.Convert<SummaryAnalysisResponse, AsyncResponseSummaryAnalysisResponse>(
                AsyncSummaryPostWithHttpInfo(request));
        }

        public async Task<ApiResponse<IAsyncResponse<SummaryAnalysisResponse>>> PostAsyncWithHttpInfo(
            SummaryAnalysisRequest request)
        {
            return Tools.Convert<SummaryAnalysisResponse, AsyncResponseSummaryAnalysisResponse>(
                await AsyncSummaryPostAsyncWithHttpInfo(request));
        }
    }

    public partial class AsyncSummaryResultApi : IAsyncApiGetter<SummaryAnalysisResponse>
    {
        public ApiResponse<IAsyncResponse<SummaryAnalysisResponse>> GetResultWithHttpInfo(
            string taskId,
            RequestCredentials credentials)
        {
            return Tools.Convert<SummaryAnalysisResponse, AsyncResponseSummaryAnalysisResponse>(
                AsyncSummaryResultGetResultWithHttpInfo(taskId, credentials));
        }

        public async Task<ApiResponse<IAsyncResponse<SummaryAnalysisResponse>>> GetResultAsyncWithHttpInfo(
            string taskId,
            RequestCredentials credentials)
        {
            return Tools.Convert<SummaryAnalysisResponse, AsyncResponseSummaryAnalysisResponse>(
                await AsyncSummaryResultGetResultAsyncWithHttpInfo(taskId, credentials));
        }
    }
}