# Neblio.API.Model.GetAddressInfoResponseUtxos
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Index** | **decimal?** | Index of the UTXO at this address | [optional] 
**Txid** | **string** | Txid of this UTXO | [optional] 
**Blockheight** | **decimal?** | Blockheight of the UTXO | [optional] 
**Blocktime** | **decimal?** | Blocktime of the UTXO | [optional] 
**ScriptPubKey** | [**Object**](.md) | Object representing the scruptPubKey of the UTXO | [optional] 
**Used** | **bool?** | Whether the UTXO has been used | [optional] 
**Value** | **decimal?** | Value of the UTXO in NEBL satoshi | [optional] 
**Tokens** | [**List&lt;GetAddressInfoResponseTokens&gt;**](GetAddressInfoResponseTokens.md) | Array of NTP1 tokens in this UTXO. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

