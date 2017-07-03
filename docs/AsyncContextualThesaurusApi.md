# ProWritingAid.SDK.Api.AsyncContextualThesaurusApi

All URIs are relative to *https://api.prowritingaid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AsyncContextualThesaurusPost**](AsyncContextualThesaurusApi.md#asynccontextualthesauruspost) | **POST** /api/async/contextualthesaurus | 


<a name="asynccontextualthesauruspost"></a>
# **AsyncContextualThesaurusPost**
> AsyncResponseContextualThesaurusResponse AsyncContextualThesaurusPost (ContextualThesaurusRequest request)



### Example
```csharp
using System;
using System.Diagnostics;
using ProWritingAid.SDK.Api;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model;

namespace Example
{
    public class AsyncContextualThesaurusPostExample
    {
        public void main()
        {
            
            var apiInstance = new AsyncContextualThesaurusApi();
            var request = new ContextualThesaurusRequest(); // ContextualThesaurusRequest | 

            try
            {
                AsyncResponseContextualThesaurusResponse result = apiInstance.AsyncContextualThesaurusPost(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AsyncContextualThesaurusApi.AsyncContextualThesaurusPost: " + e.Message );
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

[**AsyncResponseContextualThesaurusResponse**](AsyncResponseContextualThesaurusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

