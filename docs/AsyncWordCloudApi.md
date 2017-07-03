# ProWritingAid.SDK.Api.AsyncWordCloudApi

All URIs are relative to *https://api.prowritingaid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AsyncWordCloudPost**](AsyncWordCloudApi.md#asyncwordcloudpost) | **POST** /api/async/wordcloud | 


<a name="asyncwordcloudpost"></a>
# **AsyncWordCloudPost**
> AsyncResponseWordCloudResponse AsyncWordCloudPost (WordCloudRequest request)



### Example
```csharp
using System;
using System.Diagnostics;
using ProWritingAid.SDK.Api;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model;

namespace Example
{
    public class AsyncWordCloudPostExample
    {
        public void main()
        {
            
            var apiInstance = new AsyncWordCloudApi();
            var request = new WordCloudRequest(); // WordCloudRequest | 

            try
            {
                AsyncResponseWordCloudResponse result = apiInstance.AsyncWordCloudPost(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AsyncWordCloudApi.AsyncWordCloudPost: " + e.Message );
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

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

