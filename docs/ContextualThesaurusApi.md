# ProWritingAid.SDK.Api.ContextualThesaurusApi

All URIs are relative to *https://api.prowritingaid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ContextualThesaurusPost**](ContextualThesaurusApi.md#contextualthesauruspost) | **POST** /api/contextualthesaurus | 


<a name="contextualthesauruspost"></a>
# **ContextualThesaurusPost**
> ContextualThesaurusResponse ContextualThesaurusPost (ContextualThesaurusRequest request)



### Example
```csharp
using System;
using System.Diagnostics;
using ProWritingAid.SDK.Api;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model;

namespace Example
{
    public class ContextualThesaurusPostExample
    {
        public void main()
        {
            
            var apiInstance = new ContextualThesaurusApi();
            var request = new ContextualThesaurusRequest(); // ContextualThesaurusRequest | 

            try
            {
                ContextualThesaurusResponse result = apiInstance.ContextualThesaurusPost(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContextualThesaurusApi.ContextualThesaurusPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ContextualThesaurusRequest**](ContextualThesaurusRequest.md)|  | 

### Return type

[**ContextualThesaurusResponse**](ContextualThesaurusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

