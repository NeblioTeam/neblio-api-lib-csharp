# Neblio.API.Model.GetTxResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Txid** | **string** | TXID of transaction | [optional] 
**Version** | **decimal?** | Transaction version | [optional] 
**Locktime** | **decimal?** | Transaction locktime | [optional] 
**Vin** | [**List&lt;GetTxResponseVin&gt;**](GetTxResponseVin.md) | Array of transaction inputs | [optional] 
**Vout** | [**List&lt;GetTxResponseVout&gt;**](GetTxResponseVout.md) | Array of transaction outputs | [optional] 
**Blocktime** | **decimal?** | Block time of this transaction | [optional] 
**Blockheight** | **decimal?** | Block height of this transaction | [optional] 
**Totalsent** | **decimal?** | Total NEBL sent in this transaction in satoshis | [optional] 
**Fee** | **decimal?** | Total NEBL used as fee for this transcation in satoshis | [optional] 
**Blockhash** | **string** | Hash of the block this transaction is in | [optional] 
**Time** | **decimal?** | Transaction time | [optional] 
**Confirmations** | **decimal?** | Number of transaction confirmations | [optional] 
**ValueOut** | **decimal?** | Total NEBL output in this transaction | [optional] 
**ValueIn** | **decimal?** | Total NEBL input in this transaction | [optional] 
**Fees** | **decimal?** | Total NEBL used in fees for this transaction | [optional] 
**Size** | **decimal?** | Transcation size in bytes | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

