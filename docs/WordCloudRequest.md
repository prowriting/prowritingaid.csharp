# ProWritingAid.SDK.Model.WordCloudRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Text** | **string** | The text to be turned into a Word Cloud | 
**Orientation** | **string** | The orientation of the text | [default to OrientationEnum.EveryWhichWay]
**CaseMethod** | **string** | The method to be used for casing | [default to CaseMethodEnum.IntelligentCase]
**PaletteName** | **string** | The name of the palette | [default to "ProWritingAid"]
**MaximumWordCount** | **int?** | the maximum number of words to be created | [default to 100]
**RemoveCommonWords** | **bool?** | Should Common words be removed from the cloud | [default to true]
**FontName** | **string** | The name of the font to use | [default to "Arial"]
**Width** | **int?** | The width of the image to produce | [default to 200]
**Height** | **int?** | The height of the image to produce | [default to 200]
**OnlySentimentWords** | **bool?** | Only use the sentiment words from the text | [default to false]
**Style** | **string** | Document&#39;s writing style | [default to StyleEnum.General]
**Language** | **string** | Document&#39;s language  Set correct UK/US language to get region-specific suggestions | [default to LanguageEnum.En]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

