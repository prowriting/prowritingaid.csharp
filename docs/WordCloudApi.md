# ProWritingAid.SDK.Api.WordCloudApi

All URIs are relative to *https://api.prowritingaid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get**](WordCloudApi.md#get) | **GET** /api/async/wordcloud/result/{taskId} | 
[**Post**](WordCloudApi.md#post) | **POST** /api/async/wordcloud | 


<a name="get"></a>
# **Get**
> AsyncResponseWordCloudResponse Get (string taskId)



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
            var apiInstance = new WordCloudApi();
            var taskId = taskId_example;  // string | 

            try
            {
                AsyncResponseWordCloudResponse result = apiInstance.Get(taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordCloudApi.Get: " + e.Message );
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

[**AsyncResponseWordCloudResponse**](AsyncResponseWordCloudResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="post"></a>
# **Post**
> AsyncResponseWordCloudResponse Post (WordCloudRequest request)



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
            var apiInstance = new WordCloudApi();
            var request = new WordCloudRequest(); // WordCloudRequest | 

            try
            {
                AsyncResponseWordCloudResponse result = apiInstance.Post(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordCloudApi.Post: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**WordCloudRequest**](WordCloudRequest.md)|  | 

### Return type

[**AsyncResponseWordCloudResponse**](AsyncResponseWordCloudResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

