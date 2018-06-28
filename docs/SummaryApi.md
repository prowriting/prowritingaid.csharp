# ProWritingAid.SDK.Api.SummaryApi

All URIs are relative to *https://api.prowritingaid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get**](SummaryApi.md#get) | **GET** /api/async/summary/result/{taskId} | Tries to get the result of a request using the task id of the request
[**Post**](SummaryApi.md#post) | **POST** /api/async/summary | Gets the summary analysis of a document


<a name="get"></a>
# **Get**
> AsyncResponseSummaryAnalysisResponse Get (string taskId)


Tries to get the result of a request using the task id of the request

### Example
```csharp
using System;
using System.Diagnostics;
using ProWritingAid.SDK.Api;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model;

namespace Example
{
    public class GetExample
    {
        public void main()
        {
            // Configure API key authorization: licenseCode
            Configuration.Default.AddApiKey("licenseCode", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("licenseCode", "Bearer");

            var apiInstance = new SummaryApi();
            var taskId = taskId_example;  // string | 

            try
            {
                // Tries to get the result of a request using the task id of the request
                AsyncResponseSummaryAnalysisResponse result = apiInstance.Get(taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SummaryApi.Get: " + e.Message );
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

[licenseCode](../README.md#licenseCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="post"></a>
# **Post**
> AsyncResponseSummaryAnalysisResponse Post (SummaryAnalysisRequest requestp)


Gets the summary analysis of a document

### Example
```csharp
using System;
using System.Diagnostics;
using ProWritingAid.SDK.Api;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model;

namespace Example
{
    public class PostExample
    {
        public void main()
        {
            // Configure API key authorization: licenseCode
            Configuration.Default.AddApiKey("licenseCode", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("licenseCode", "Bearer");

            var apiInstance = new SummaryApi();
            var requestp = new SummaryAnalysisRequest(); // SummaryAnalysisRequest | 

            try
            {
                // Gets the summary analysis of a document
                AsyncResponseSummaryAnalysisResponse result = apiInstance.Post(requestp);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SummaryApi.Post: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestp** | [**SummaryAnalysisRequest**](SummaryAnalysisRequest.md)|  | 

### Return type

[**AsyncResponseSummaryAnalysisResponse**](AsyncResponseSummaryAnalysisResponse.md)

### Authorization

[licenseCode](../README.md#licenseCode)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

