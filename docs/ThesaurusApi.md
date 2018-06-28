# ProWritingAid.SDK.Api.ThesaurusApi

All URIs are relative to *https://api.prowritingaid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Post**](ThesaurusApi.md#post) | **POST** /api/thesaurus | Returns the thesaurus entries for a specific word


<a name="post"></a>
# **Post**
> ThesaurusResponse Post (ThesaurusRequest request)

Returns the thesaurus entries for a specific word

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

            var apiInstance = new ThesaurusApi();
            var request = new ThesaurusRequest(); // ThesaurusRequest | 

            try
            {
                // Returns the thesaurus entries for a specific word
                ThesaurusResponse result = apiInstance.Post(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThesaurusApi.Post: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ThesaurusRequest**](ThesaurusRequest.md)|  | 

### Return type

[**ThesaurusResponse**](ThesaurusResponse.md)

### Authorization

[licenseCode](../README.md#licenseCode)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

