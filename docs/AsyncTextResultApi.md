# ProWritingAid.SDK.Api.AsyncTextResultApi

All URIs are relative to *https://api.prowritingaid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AsyncTextResultGetResult**](AsyncTextResultApi.md#asynctextresultgetresult) | **GET** /api/async/result/text/{taskId} | 


<a name="asynctextresultgetresult"></a>
# **AsyncTextResultGetResult**
> TextAnalysisResponse AsyncTextResultGetResult (string taskId)



### Example
```csharp
using System;
using System.Diagnostics;
using ProWritingAid.SDK.Api;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model;

namespace Example
{
    public class AsyncTextResultGetResultExample
    {
        public void main()
        {
            
            var apiInstance = new AsyncTextResultApi();
            var taskId = taskId_example;  // string | 

            try
            {
                TextAnalysisResponse result = apiInstance.AsyncTextResultGetResult(taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AsyncTextResultApi.AsyncTextResultGetResult: " + e.Message );
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

[**TextAnalysisResponse**](TextAnalysisResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

