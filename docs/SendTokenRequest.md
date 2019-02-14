# Neblio.API.Model.SendTokenRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Fee** | **decimal?** | Fee in satoshi to include in the issuance transaction min 10000 (0.0001 NEBL) | 
**From** | **List&lt;string&gt;** | Array of addresses to send the token from | [optional] 
**Sendutxo** | **List&lt;string&gt;** | Array of UTXOs to send the token from | [optional] 
**To** | [**List&lt;SendTokenRequestTo&gt;**](SendTokenRequestTo.md) |  | 
**Flags** | [**IssueTokenRequestFlags**](IssueTokenRequestFlags.md) |  | [optional] 
**Metadata** | [**IssueTokenRequestMetadata**](IssueTokenRequestMetadata.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

