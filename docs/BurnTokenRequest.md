# Neblio.API.Model.BurnTokenRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Fee** | **decimal?** | Fee in satoshi to include in the issuance transaction min 10000 (0.0001 NEBL) | 
**From** | **List&lt;string&gt;** | Array of addresses to send the token from | [optional] 
**Transfer** | [**List&lt;SendTokenRequestTo&gt;**](SendTokenRequestTo.md) |  | [optional] 
**Burn** | [**List&lt;BurnTokenRequestBurn&gt;**](BurnTokenRequestBurn.md) | Array of objects representing tokens to be burned | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

