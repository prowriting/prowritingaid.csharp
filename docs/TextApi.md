# ProWritingAid.SDK.Api.TextApi

All URIs are relative to *https://api.prowritingaid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TextPost**](TextApi.md#textpost) | **POST** /api/text | 


<a name="textpost"></a>
# **TextPost**
> TextAnalysisResponse TextPost (TextAnalysisRequest request)



### Example
```csharp
using System;
using System.Diagnostics;
using ProWritingAid.SDK.Api;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model;

namespace Example
{
    public class TextPostExample
    {
        public void main()
        {
            
            var apiInstance = new TextApi();
            var request = new TextAnalysisRequest(); // TextAnalysisRequest | 

            try
            {
                TextAnalysisResponse result = apiInstance.TextPost(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TextApi.TextPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**TextAnalysisRequest**](TextAnalysisRequest.md)|  | 

### Return type

[**TextAnalysisResponse**](TextAnalysisResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

