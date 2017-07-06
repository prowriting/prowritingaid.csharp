# ProWritingAid.SDK.Api.AsyncHtmlResultApi

All URIs are relative to *https://api.prowritingaid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AsyncHtmlResultGetResult**](AsyncHtmlResultApi.md#asynchtmlresultgetresult) | **GET** /api/async/result/html/{taskId} | 


<a name="asynchtmlresultgetresult"></a>
# **AsyncHtmlResultGetResult**
> AsyncResponseHtmlAnalysisResponse AsyncHtmlResultGetResult (string taskId)



### Example
```csharp
using System;
using System.Diagnostics;
using ProWritingAid.SDK.Api;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model;

namespace Example
{
    public class AsyncHtmlResultGetResultExample
    {
        public void main()
        {
            
            var apiInstance = new AsyncHtmlResultApi();
            var taskId = taskId_example;  // string | 

            try
            {
                AsyncResponseHtmlAnalysisResponse result = apiInstance.AsyncHtmlResultGetResult(taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AsyncHtmlResultApi.AsyncHtmlResultGetResult: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**|  | 

### Return type

[**AsyncResponseHtmlAnalysisResponse**](AsyncResponseHtmlAnalysisResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

