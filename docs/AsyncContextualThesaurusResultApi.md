# ProWritingAid.SDK.Api.AsyncContextualThesaurusResultApi

All URIs are relative to *https://api.prowritingaid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AsyncContextualThesaurusResultGetResult**](AsyncContextualThesaurusResultApi.md#asynccontextualthesaurusresultgetresult) | **GET** /api/async/result/contextualthesaurus/{taskId} | 


<a name="asynccontextualthesaurusresultgetresult"></a>
# **AsyncContextualThesaurusResultGetResult**
> ContextualThesaurusResponse AsyncContextualThesaurusResultGetResult (string taskId)



### Example
```csharp
using System;
using System.Diagnostics;
using ProWritingAid.SDK.Api;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model;

namespace Example
{
    public class AsyncContextualThesaurusResultGetResultExample
    {
        public void main()
        {
            
            var apiInstance = new AsyncContextualThesaurusResultApi();
            var taskId = taskId_example;  // string | 

            try
            {
                ContextualThesaurusResponse result = apiInstance.AsyncContextualThesaurusResultGetResult(taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AsyncContextualThesaurusResultApi.AsyncContextualThesaurusResultGetResult: " + e.Message );
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

[**ContextualThesaurusResponse**](ContextualThesaurusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

