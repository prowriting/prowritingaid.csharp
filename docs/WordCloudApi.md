# ProWritingAid.SDK.Api.WordCloudApi

All URIs are relative to *https://api.prowritingaid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WordCloudPost**](WordCloudApi.md#wordcloudpost) | **POST** /api/wordcloud | 


<a name="wordcloudpost"></a>
# **WordCloudPost**
> WordCloudResponse WordCloudPost (WordCloudRequest request)



### Example
```csharp
using System;
using System.Diagnostics;
using ProWritingAid.SDK.Api;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model;

namespace Example
{
    public class WordCloudPostExample
    {
        public void main()
        {
            
            var apiInstance = new WordCloudApi();
            var request = new WordCloudRequest(); // WordCloudRequest | 

            try
            {
                WordCloudResponse result = apiInstance.WordCloudPost(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WordCloudApi.WordCloudPost: " + e.Message );
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

[**WordCloudResponse**](WordCloudResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

