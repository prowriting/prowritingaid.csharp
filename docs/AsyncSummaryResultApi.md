# ProWritingAid.SDK.Api.AsyncSummaryResultApi

All URIs are relative to *https://api.prowritingaid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AsyncSummaryResultGetResult**](AsyncSummaryResultApi.md#asyncsummaryresultgetresult) | **GET** /api/async/result/summary/{taskId} | 


<a name="asyncsummaryresultgetresult"></a>
# **AsyncSummaryResultGetResult**
> AsyncResponseSummaryAnalysisResponse AsyncSummaryResultGetResult (string taskId)



### Example
```csharp
using System;
using System.Diagnostics;
using ProWritingAid.SDK.Api;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model;

namespace Example
{
    public class AsyncSummaryResultGetResultExample
    {
        public void main()
        {
            
            var apiInstance = new AsyncSummaryResultApi();
            var taskId = taskId_example;  // string | 

            try
            {
                AsyncResponseSummaryAnalysisResponse result = apiInstance.AsyncSummaryResultGetResult(taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AsyncSummaryResultApi.AsyncSummaryResultGetResult: " + e.Message );
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

[**AsyncResponseSummaryAnalysisResponse**](AsyncResponseSummaryAnalysisResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

