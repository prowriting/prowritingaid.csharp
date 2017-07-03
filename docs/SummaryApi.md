# ProWritingAid.SDK.Api.SummaryApi

All URIs are relative to *https://api.prowritingaid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SummaryPost**](SummaryApi.md#summarypost) | **POST** /api/summary | 


<a name="summarypost"></a>
# **SummaryPost**
> SummaryAnalysisResponse SummaryPost (SummaryAnalysisRequest request)



### Example
```csharp
using System;
using System.Diagnostics;
using ProWritingAid.SDK.Api;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model;

namespace Example
{
    public class SummaryPostExample
    {
        public void main()
        {
            
            var apiInstance = new SummaryApi();
            var request = new SummaryAnalysisRequest(); // SummaryAnalysisRequest | 

            try
            {
                SummaryAnalysisResponse result = apiInstance.SummaryPost(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SummaryApi.SummaryPost: " + e.Message );
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

[**SummaryAnalysisResponse**](SummaryAnalysisResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

