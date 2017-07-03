# ProWritingAid.SDK.Api.AsyncHtmlApi

All URIs are relative to *https://api.prowritingaid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AsyncHtmlPost**](AsyncHtmlApi.md#asynchtmlpost) | **POST** /api/async/html | 


<a name="asynchtmlpost"></a>
# **AsyncHtmlPost**
> AsyncResponseHtmlAnalysisResponse AsyncHtmlPost (HtmlAnalysisRequest request)



### Example
```csharp
using System;
using System.Diagnostics;
using ProWritingAid.SDK.Api;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model;

namespace Example
{
    public class AsyncHtmlPostExample
    {
        public void main()
        {
            
            var apiInstance = new AsyncHtmlApi();
            var request = new HtmlAnalysisRequest(); // HtmlAnalysisRequest | 

            try
            {
                AsyncResponseHtmlAnalysisResponse result = apiInstance.AsyncHtmlPost(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AsyncHtmlApi.AsyncHtmlPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**HtmlAnalysisRequest**](HtmlAnalysisRequest.md)|  | 

### Return type

[**AsyncResponseHtmlAnalysisResponse**](AsyncResponseHtmlAnalysisResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

