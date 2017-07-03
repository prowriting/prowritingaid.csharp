# ProWritingAid.SDK.Api.AsyncTextApi

All URIs are relative to *https://api.prowritingaid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AsyncTextPost**](AsyncTextApi.md#asynctextpost) | **POST** /api/async/text | 


<a name="asynctextpost"></a>
# **AsyncTextPost**
> AsyncResponseTextAnalysisResponse AsyncTextPost (TextAnalysisRequest request)



### Example
```csharp
using System;
using System.Diagnostics;
using ProWritingAid.SDK.Api;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model;

namespace Example
{
    public class AsyncTextPostExample
    {
        public void main()
        {
            
            var apiInstance = new AsyncTextApi();
            var request = new TextAnalysisRequest(); // TextAnalysisRequest | 

            try
            {
                AsyncResponseTextAnalysisResponse result = apiInstance.AsyncTextPost(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AsyncTextApi.AsyncTextPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**TextAnalysisRequest**](TextAnalysisRequest.md)|  | 

### Return type

[**AsyncResponseTextAnalysisResponse**](AsyncResponseTextAnalysisResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

