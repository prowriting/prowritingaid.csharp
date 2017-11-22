# ProWritingAid.SDK

[![Build status](https://ci.appveyor.com/api/projects/status/uw618e4sbv978jwg?svg=true)](https://ci.appveyor.com/project/prowriting/prowritingaid-csharp)

C# library for the ProWritingAid.API

- API version: v2
- SDK version: 2.0.0
- [Nuget package](https://www.nuget.org/packages/ProWritingAid.SDK/)

## Frameworks supported
- .NET 4.5 or later

## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.2.3 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 10.0.2 or later

The DLLs included in the package may not be the latest version. We recommned using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

## Installation
Install SDK using [Nuget package](https://www.nuget.org/packages/ProWritingAid.SDK/).

## Getting Started

```csharp
using System;
using System.Collections.Generic;
using System.Diagnostics;
using ProWritingAid.SDK.Api;
using ProWritingAid.SDK.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
                
            var api = new TextAsyncApi()
                .SetLicenseCode("00000000-0000-0000-0000-2212FC205139");
            var request = new TextAnalysisRequest(
                "I'd like to by that toy. wood you help me? I have twp more brothers.",
                new List<string> {"grammar"},
                TextAnalysisRequest.StyleEnum.General,
                TextAnalysisRequest.LanguageEnum.En); 
    
            try
            {
                var response = api.Post(request);
                Debug.WriteLine(response);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TextApi.TextPost: " + e.Message );
            }
        }
    }
}

```


<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.prowritingaid.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ContextualThesaurusApi* | [**Get**](docs/ContextualThesaurusApi.md#get) | **GET** /api/async/contextualthesaurus/result/{taskId} | 
*ContextualThesaurusApi* | [**Post**](docs/ContextualThesaurusApi.md#post) | **POST** /api/async/contextualthesaurus | 
*HtmlApi* | [**Get**](docs/HtmlApi.md#get) | **GET** /api/async/html/result/{taskId} | 
*HtmlApi* | [**Post**](docs/HtmlApi.md#post) | **POST** /api/async/html | 
*SummaryApi* | [**Get**](docs/SummaryApi.md#get) | **GET** /api/async/summary/result/{taskId} | 
*SummaryApi* | [**Post**](docs/SummaryApi.md#post) | **POST** /api/async/summary | 
*TextApi* | [**Get**](docs/TextApi.md#get) | **GET** /api/async/text/result/{taskId} | 
*TextApi* | [**Post**](docs/TextApi.md#post) | **POST** /api/async/text | 
*WordCloudApi* | [**Get**](docs/WordCloudApi.md#get) | **GET** /api/async/wordcloud/result/{taskId} | 
*WordCloudApi* | [**Post**](docs/WordCloudApi.md#post) | **POST** /api/async/wordcloud | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AnalysisSettings](docs/AnalysisSettings.md)
 - [Model.AnalysisSummary](docs/AnalysisSummary.md)
 - [Model.AnalysisSummaryGraph](docs/AnalysisSummaryGraph.md)
 - [Model.AnalysisSummaryGraphItem](docs/AnalysisSummaryGraphItem.md)
 - [Model.AnalysisSummaryItem](docs/AnalysisSummaryItem.md)
 - [Model.AnalysisSummarySubItem](docs/AnalysisSummarySubItem.md)
 - [Model.AsyncResponseContextualThesaurusResponse](docs/AsyncResponseContextualThesaurusResponse.md)
 - [Model.AsyncResponseHtmlAnalysisResponse](docs/AsyncResponseHtmlAnalysisResponse.md)
 - [Model.AsyncResponseSummaryAnalysisResponse](docs/AsyncResponseSummaryAnalysisResponse.md)
 - [Model.AsyncResponseTextAnalysisResponse](docs/AsyncResponseTextAnalysisResponse.md)
 - [Model.AsyncResponseWordCloudResponse](docs/AsyncResponseWordCloudResponse.md)
 - [Model.ContextualThesaurusRequest](docs/ContextualThesaurusRequest.md)
 - [Model.ContextualThesaurusResponse](docs/ContextualThesaurusResponse.md)
 - [Model.DocTag](docs/DocTag.md)
 - [Model.HtmlAnalysisRequest](docs/HtmlAnalysisRequest.md)
 - [Model.HtmlAnalysisResponse](docs/HtmlAnalysisResponse.md)
 - [Model.SuggestionCategory](docs/SuggestionCategory.md)
 - [Model.SummaryAnalysisRequest](docs/SummaryAnalysisRequest.md)
 - [Model.SummaryAnalysisResponse](docs/SummaryAnalysisResponse.md)
 - [Model.TextAnalysisRequest](docs/TextAnalysisRequest.md)
 - [Model.TextAnalysisResponse](docs/TextAnalysisResponse.md)
 - [Model.WordCloudRequest](docs/WordCloudRequest.md)
 - [Model.WordCloudResponse](docs/WordCloudResponse.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="licenseCode"></a>
### licenseCode

- **Type**: API key
- **API key parameter name**: licenseCode
- **Location**: HTTP header

