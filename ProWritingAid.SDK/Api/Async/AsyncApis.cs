using System;
using System.Threading.Tasks;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model;

namespace ProWritingAid.SDK.Api.Async
{
    public class ContextualThesaurusAsyncApi :
        AsyncApiBase<ContextualThesaurusRequest, ContextualThesaurusResponse, AsyncContextualThesaurusApi,
            AsyncContextualThesaurusResultApi>,
        IContextualThesaurusApi
    {
        public ContextualThesaurusAsyncApi(string basePath, int monitoringTimeStepInMs = DefaultMonitoringTimeStepInMs)
            : base(
                new AsyncContextualThesaurusApi(basePath),
                new AsyncContextualThesaurusResultApi(basePath),
                monitoringTimeStepInMs)
        {
        }

        public ContextualThesaurusAsyncApi(
            Configuration configuration = null,
            int monitoringTimeStepInMs = DefaultMonitoringTimeStepInMs)
            : base(
                new AsyncContextualThesaurusApi(configuration),
                new AsyncContextualThesaurusResultApi(configuration),
                monitoringTimeStepInMs)
        {
        }

        public ContextualThesaurusResponse ContextualThesaurusPost(ContextualThesaurusRequest request)
        {
            var localVarResponse = PostWithHttpInfo(request);
            return localVarResponse.Data;
        }

        public ApiResponse<ContextualThesaurusResponse> ContextualThesaurusPostWithHttpInfo(
            ContextualThesaurusRequest request)
        {
            return PostWithHttpInfo(request);
        }

        public async Task<ContextualThesaurusResponse> ContextualThesaurusPostAsync(ContextualThesaurusRequest request)
        {
            var localVarResponse = await PostAsyncWithHttpInfo(request);
            return localVarResponse.Data;
        }

        public async Task<ApiResponse<ContextualThesaurusResponse>> ContextualThesaurusPostAsyncWithHttpInfo(
            ContextualThesaurusRequest request)
        {
            return await PostAsyncWithHttpInfo(request);
        }
    }

    public class WordCloudAsyncApi :
        AsyncApiBase<WordCloudRequest, WordCloudResponse, AsyncWordCloudApi,
            AsyncWordCloudResultApi>,
        IWordCloudApi
    {
        public WordCloudAsyncApi(string basePath, int monitoringTimeStepInMs = DefaultMonitoringTimeStepInMs)
            : base(
                new AsyncWordCloudApi(basePath),
                new AsyncWordCloudResultApi(basePath),
                monitoringTimeStepInMs)
        {
        }

        public WordCloudAsyncApi(
            Configuration configuration = null,
            int monitoringTimeStepInMs = DefaultMonitoringTimeStepInMs)
            : base(
                new AsyncWordCloudApi(configuration),
                new AsyncWordCloudResultApi(configuration),
                monitoringTimeStepInMs)
        {
        }

        public WordCloudResponse WordCloudPost(WordCloudRequest request)
        {
            var localVarResponse = PostWithHttpInfo(request);
            return localVarResponse.Data;
        }

        public ApiResponse<WordCloudResponse> WordCloudPostWithHttpInfo(
            WordCloudRequest request)
        {
            return PostWithHttpInfo(request);
        }

        public async Task<WordCloudResponse> WordCloudPostAsync(WordCloudRequest request)
        {
            var localVarResponse = await PostAsyncWithHttpInfo(request);
            return localVarResponse.Data;
        }

        public async Task<ApiResponse<WordCloudResponse>> WordCloudPostAsyncWithHttpInfo(
            WordCloudRequest request)
        {
            return await PostAsyncWithHttpInfo(request);
        }
    }

    public class TextAsyncApi :
        AsyncApiBase<TextAnalysisRequest, TextAnalysisResponse, AsyncTextApi,
            AsyncTextResultApi>,
        ITextApi
    {
        public TextAsyncApi(string basePath, int monitoringTimeStepInMs = DefaultMonitoringTimeStepInMs)
            : base(
                new AsyncTextApi(basePath),
                new AsyncTextResultApi(basePath),
                monitoringTimeStepInMs)
        {
        }

        public TextAsyncApi(
            Configuration configuration = null,
            int monitoringTimeStepInMs = DefaultMonitoringTimeStepInMs)
            : base(
                new AsyncTextApi(configuration),
                new AsyncTextResultApi(configuration),
                monitoringTimeStepInMs)
        {
        }

        public TextAnalysisResponse TextPost(TextAnalysisRequest request)
        {
            var localVarResponse = PostWithHttpInfo(request);
            return localVarResponse.Data;
        }

        public ApiResponse<TextAnalysisResponse> TextPostWithHttpInfo(
            TextAnalysisRequest request)
        {
            return PostWithHttpInfo(request);
        }

        public async Task<TextAnalysisResponse> TextPostAsync(TextAnalysisRequest request)
        {
            var localVarResponse = await PostAsyncWithHttpInfo(request);
            return localVarResponse.Data;
        }

        public async Task<ApiResponse<TextAnalysisResponse>> TextPostAsyncWithHttpInfo(
            TextAnalysisRequest request)
        {
            return await PostAsyncWithHttpInfo(request);
        }
    }

    public class HtmlAsyncApi :
        AsyncApiBase<HtmlAnalysisRequest, HtmlAnalysisResponse, AsyncHtmlApi,
            AsyncHtmlResultApi>,
        IHtmlApi
    {
        public HtmlAsyncApi(string basePath, int monitoringTimeStepInMs = DefaultMonitoringTimeStepInMs)
            : base(
                new AsyncHtmlApi(basePath),
                new AsyncHtmlResultApi(basePath),
                monitoringTimeStepInMs)
        {
        }

        public HtmlAsyncApi(
            Configuration configuration = null,
            int monitoringTimeStepInMs = DefaultMonitoringTimeStepInMs)
            : base(
                new AsyncHtmlApi(configuration),
                new AsyncHtmlResultApi(configuration),
                monitoringTimeStepInMs)
        {
        }

        public HtmlAnalysisResponse HtmlPost(HtmlAnalysisRequest request)
        {
            var localVarResponse = PostWithHttpInfo(request);
            return localVarResponse.Data;
        }

        public ApiResponse<HtmlAnalysisResponse> HtmlPostWithHttpInfo(
            HtmlAnalysisRequest request)
        {
            return PostWithHttpInfo(request);
        }

        public async Task<HtmlAnalysisResponse> HtmlPostAsync(HtmlAnalysisRequest request)
        {
            var localVarResponse = await PostAsyncWithHttpInfo(request);
            return localVarResponse.Data;
        }

        public async Task<ApiResponse<HtmlAnalysisResponse>> HtmlPostAsyncWithHttpInfo(
            HtmlAnalysisRequest request)
        {
            return await PostAsyncWithHttpInfo(request);
        }
    }

    public class SummaryAsyncApi :
        AsyncApiBase<SummaryAnalysisRequest, SummaryAnalysisResponse, AsyncSummaryApi,
            AsyncSummaryResultApi>,
        ISummaryApi
    {
        public SummaryAsyncApi(string basePath, int monitoringTimeStepInMs = DefaultMonitoringTimeStepInMs)
            : base(
                new AsyncSummaryApi(basePath),
                new AsyncSummaryResultApi(basePath),
                monitoringTimeStepInMs)
        {
        }

        public SummaryAsyncApi(
            Configuration configuration = null,
            int monitoringTimeStepInMs = DefaultMonitoringTimeStepInMs)
            : base(
                new AsyncSummaryApi(configuration),
                new AsyncSummaryResultApi(configuration),
                monitoringTimeStepInMs)
        {
        }

        public SummaryAnalysisResponse SummaryPost(SummaryAnalysisRequest request)
        {
            var localVarResponse = PostWithHttpInfo(request);
            return localVarResponse.Data;
        }

        public ApiResponse<SummaryAnalysisResponse> SummaryPostWithHttpInfo(
            SummaryAnalysisRequest request)
        {
            return PostWithHttpInfo(request);
        }

        public async Task<SummaryAnalysisResponse> SummaryPostAsync(SummaryAnalysisRequest request)
        {
            var localVarResponse = await PostAsyncWithHttpInfo(request);
            return localVarResponse.Data;
        }

        public async Task<ApiResponse<SummaryAnalysisResponse>> SummaryPostAsyncWithHttpInfo(
            SummaryAnalysisRequest request)
        {
            return await PostAsyncWithHttpInfo(request);
        }
    }
}