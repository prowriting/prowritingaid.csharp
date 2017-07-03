# ProWritingAid.SDK.Api.AsyncSummaryApi

All URIs are relative to *https://api.prowritingaid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AsyncSummaryPost**](AsyncSummaryApi.md#asyncsummarypost) | **POST** /api/async/summary | 


<a name="asyncsummarypost"></a>
# **AsyncSummaryPost**
> AsyncResponseSummaryAnalysisResponse AsyncSummaryPost (SummaryAnalysisRequest request)



### Example
```csharp
using System;
using System.Diagnostics;
using ProWritingAid.SDK.Api;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model;

namespace Example
{
    public class AsyncSummaryPostExample
    {
        public void main()
        {
            
            var apiInstance = new AsyncSummaryApi();
            var request = new SummaryAnalysisRequest(); // SummaryAnalysisRequest | 

            try
            {
                AsyncResponseSummaryAnalysisResponse result = apiInstance.AsyncSummaryPost(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AsyncSummaryApi.AsyncSummaryPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SummaryAnalysisRequest**](SummaryAnalysisRequest.md)|  | 

### Return type

[**AsyncResponseSummaryAnalysisResponse**](AsyncResponseSummaryAnalysisResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

