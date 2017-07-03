# ProWritingAid.SDK.Api.HtmlApi

All URIs are relative to *https://api.prowritingaid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HtmlPost**](HtmlApi.md#htmlpost) | **POST** /api/html | 


<a name="htmlpost"></a>
# **HtmlPost**
> HtmlAnalysisResponse HtmlPost (HtmlAnalysisRequest request)



### Example
```csharp
using System;
using System.Diagnostics;
using ProWritingAid.SDK.Api;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model;

namespace Example
{
    public class HtmlPostExample
    {
        public void main()
        {
            
            var apiInstance = new HtmlApi();
            var request = new HtmlAnalysisRequest(); // HtmlAnalysisRequest | 

            try
            {
                HtmlAnalysisResponse result = apiInstance.HtmlPost(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HtmlApi.HtmlPost: " + e.Message );
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

[**HtmlAnalysisResponse**](HtmlAnalysisResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

