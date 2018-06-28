# ProWritingAid.SDK.Api.ContextualThesaurusApi

All URIs are relative to *https://api.prowritingaid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get**](ContextualThesaurusApi.md#get) | **GET** /api/async/contextualthesaurus/result/{taskId} | Tries to get the result of a request using the task id of the request
[**Post**](ContextualThesaurusApi.md#post) | **POST** /api/async/contextualthesaurus | Analyses text and returns contextual thesaurus entries


<a name="get"></a>
# **Get**
> AsyncResponseContextualThesaurusResponse Get (string taskId)


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

            var apiInstance = new ContextualThesaurusApi();
            var taskId = taskId_example;  // string | 

            try
            {
                // Tries to get the result of a request using the task id of the request
                AsyncResponseContextualThesaurusResponse result = apiInstance.Get(taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContextualThesaurusApi.Get: " + e.Message );
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

[**AsyncResponseContextualThesaurusResponse**](AsyncResponseContextualThesaurusResponse.md)

### Authorization

[licenseCode](../README.md#licenseCode)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="post"></a>
# **Post**
> AsyncResponseContextualThesaurusResponse Post (ContextualThesaurusRequest requestp)


Analyses text and returns contextual thesaurus entries

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

            var apiInstance = new ContextualThesaurusApi();
            var requestp = new ContextualThesaurusRequest(); // ContextualThesaurusRequest | 

            try
            {
                // Analyses text and returns contextual thesaurus entries
                AsyncResponseContextualThesaurusResponse result = apiInstance.Post(requestp);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContextualThesaurusApi.Post: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestp** | [**ContextualThesaurusRequest**](ContextualThesaurusRequest.md)|  | 

### Return type

[**AsyncResponseContextualThesaurusResponse**](AsyncResponseContextualThesaurusResponse.md)

### Authorization

[licenseCode](../README.md#licenseCode)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

