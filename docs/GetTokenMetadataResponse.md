# Neblio.API.Model.GetTokenMetadataResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TokenId** | **string** | ID of the token | [optional] 
**SomeUtxo** | **string** | Example UTXO containing this token. | [optional] 
**Divisibility** | **decimal?** | Decimal places the token is divisible to | [optional] 
**LockStatus** | **bool?** | Whether issuance of more tokens is locked | [optional] 
**AggregationPolicy** | **string** | Whether the tokens are aggregatable | [optional] 
**InitialIssuanceAmount** | **decimal?** | Total tokens issued in initial issuance | [optional] 
**TotalSupply** | **decimal?** | Total number of tokens in supply | [optional] 
**NumOfHolders** | **decimal?** | Total number of addresses this token is held at | [optional] 
**NumOfTransfers** | **decimal?** | Total number of transactions of this token | [optional] 
**NumOfIssuance** | **decimal?** | Total number of times this token has been issued | [optional] 
**NumOfBurns** | **decimal?** | Number of times tokens have been burned | [optional] 
**FirstBlock** | **decimal?** | Block number token was issued in | [optional] 
**IssuanceTxid** | **string** | TXID the token was issued with | [optional] 
**IssueAddress** | **string** | Address that issued the tokens | [optional] 
**MetadataOfIssuance** | [**GetTokenMetadataResponseMetadataOfIssuance**](GetTokenMetadataResponseMetadataOfIssuance.md) |  | [optional] 
**MetadataOfUtxo** | [**GetTokenMetadataResponseMetadataOfUtxo**](GetTokenMetadataResponseMetadataOfUtxo.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

