# ProWritingAid.SDK.Api.AsyncWordCloudResultApi

All URIs are relative to *https://api.prowritingaid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AsyncWordCloudResultGetResult**](AsyncWordCloudResultApi.md#asyncwordcloudresultgetresult) | **GET** /api/async/result/wordcloud/{taskId} | 


<a name="asyncwordcloudresultgetresult"></a>
# **AsyncWordCloudResultGetResult**
> WordCloudResponse AsyncWordCloudResultGetResult (string taskId)



### Example
```csharp
using System;
using System.Diagnostics;
using ProWritingAid.SDK.Api;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model;

namespace Example
{
    public class AsyncWordCloudResultGetResultExample
    {
        public void main()
        {
            
            var apiInstance = new AsyncWordCloudResultApi();
            var taskId = taskId_example;  // string | 

            try
            {
                WordCloudResponse result = apiInstance.AsyncWordCloudResultGetResult(taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AsyncWordCloudResultApi.AsyncWordCloudResultGetResult: " + e.Message );
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

[**WordCloudResponse**](WordCloudResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

