using ProWritingAid.SDK.Api.Async;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model;

// ReSharper disable once CheckNamespace
namespace ProWritingAid.SDK.Api
{
    public partial class ContextualThesaurusApi
        : IAsyncApi<ContextualThesaurusRequest,
            ContextualThesaurusResponse, AsyncResponseContextualThesaurusResponse>
    {
    }

    public class ContextualThesaurusAsyncApi : PollingApi<ContextualThesaurusRequest, ContextualThesaurusResponse,
        AsyncResponseContextualThesaurusResponse>
    {
        public ContextualThesaurusAsyncApi(string basePath, int monitoringTimeStepInMs = DefaultMonitoringTimeStepInMs)
            : base(
                new ContextualThesaurusApi(basePath),
                monitoringTimeStepInMs)
        {
        }

        public ContextualThesaurusAsyncApi(
            Configuration configuration = null,
            int monitoringTimeStepInMs = DefaultMonitoringTimeStepInMs)
            : base(
                new ContextualThesaurusApi(configuration),
                monitoringTimeStepInMs)
        {
        }
    }


    public partial class WordCloudApi
        : IAsyncApi<WordCloudRequest,
            WordCloudResponse, AsyncResponseWordCloudResponse>
    {
    }

    public class WordCloudAsyncApi : PollingApi<WordCloudRequest, WordCloudResponse, AsyncResponseWordCloudResponse>
    {
        public WordCloudAsyncApi(string basePath, int monitoringTimeStepInMs = DefaultMonitoringTimeStepInMs)
            : base(
                new WordCloudApi(basePath),
                monitoringTimeStepInMs)
        {
        }

        public WordCloudAsyncApi(
            Configuration configuration = null,
            int monitoringTimeStepInMs = DefaultMonitoringTimeStepInMs)
            : base(
                new WordCloudApi(configuration),
                monitoringTimeStepInMs)
        {
        }
    }


    public partial class TextApi
        : IAsyncApi<TextAnalysisRequest,
            TextAnalysisResponse, AsyncResponseTextAnalysisResponse>
    {
    }

    public class TextAsyncApi : PollingApi<TextAnalysisRequest, TextAnalysisResponse, AsyncResponseTextAnalysisResponse>
    {
        public TextAsyncApi(string basePath, int monitoringTimeStepInMs = DefaultMonitoringTimeStepInMs)
            : base(
                new TextApi(basePath),
                monitoringTimeStepInMs)
        {
        }

        public TextAsyncApi(
            Configuration configuration = null,
            int monitoringTimeStepInMs = DefaultMonitoringTimeStepInMs)
            : base(
                new TextApi(configuration),
                monitoringTimeStepInMs)
        {
        }
    }


    public partial class HtmlApi
        : IAsyncApi<HtmlAnalysisRequest,
            HtmlAnalysisResponse, AsyncResponseHtmlAnalysisResponse>
    {
    }

    public class HtmlAsyncApi : PollingApi<HtmlAnalysisRequest, HtmlAnalysisResponse, AsyncResponseHtmlAnalysisResponse>
    {
        public HtmlAsyncApi(string basePath, int monitoringTimeStepInMs = DefaultMonitoringTimeStepInMs)
            : base(
                new HtmlApi(basePath),
                monitoringTimeStepInMs)
        {
        }

        public HtmlAsyncApi(
            Configuration configuration = null,
            int monitoringTimeStepInMs = DefaultMonitoringTimeStepInMs)
            : base(
                new HtmlApi(configuration),
                monitoringTimeStepInMs)
        {
        }
    }


    public partial class SummaryApi
        : IAsyncApi<SummaryAnalysisRequest,
            SummaryAnalysisResponse, AsyncResponseSummaryAnalysisResponse>
    {
    }

    public class SummaryAsyncApi : PollingApi<SummaryAnalysisRequest, SummaryAnalysisResponse,
        AsyncResponseSummaryAnalysisResponse>
    {
        public SummaryAsyncApi(string basePath, int monitoringTimeStepInMs = DefaultMonitoringTimeStepInMs)
            : base(
                new SummaryApi(basePath),
                monitoringTimeStepInMs)
        {
        }

        public SummaryAsyncApi(
            Configuration configuration = null,
            int monitoringTimeStepInMs = DefaultMonitoringTimeStepInMs)
            : base(
                new SummaryApi(configuration),
                monitoringTimeStepInMs)
        {
        }
    }
}