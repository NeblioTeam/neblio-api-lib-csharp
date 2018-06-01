# IO.Swagger.Model.IssueTokenRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IssueAddress** | **string** | Address issuing the token | 
**Amount** | **decimal?** | Number of tokens to issue | 
**Divisibility** | **decimal?** | Number of decimal places the token should be divisble by (0-7) | 
**Fee** | **decimal?** | Fee in satoshi to include in the issuance transaction min 1000000000 (10 NEBL) | 
**Reissuable** | **bool?** | whether the token should be reissuable | 
**Flags** | [**IssueTokenRequestFlags**](IssueTokenRequestFlags.md) |  | [optional] 
**Metadata** | [**IssueTokenRequestMetadata**](IssueTokenRequestMetadata.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

