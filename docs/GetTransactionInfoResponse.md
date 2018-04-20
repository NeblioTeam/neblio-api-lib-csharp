# IO.Swagger.Model.GetTransactionInfoResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hex** | **string** | Transaction in raw hex | [optional] 
**Txid** | **string** | TXID of transaction | [optional] 
**Version** | **decimal?** | Transaction version | [optional] 
**Locktime** | **decimal?** | Transaction locktime | [optional] 
**Vin** | [**List&lt;GetTransactionInfoResponseVin&gt;**](GetTransactionInfoResponseVin.md) | Array of transaction inputs | [optional] 
**Vout** | [**List&lt;GetTransactionInfoResponseVout&gt;**](GetTransactionInfoResponseVout.md) | Array of transaction outputs | [optional] 
**Blocktime** | **decimal?** | Block time of this transaction | [optional] 
**Blockheight** | **decimal?** | Block height of this transaction | [optional] 
**Totalsent** | **decimal?** | Total NEBL sent in this transaction in satoshis | [optional] 
**Fee** | **decimal?** | Total NEBL used as fee for this transcation in satoshis | [optional] 
**Blockhash** | **string** | Hash of the block this transaction is in | [optional] 
**Time** | **decimal?** | Transaction time | [optional] 
**Confirmations** | **decimal?** | Number of transaction confirmations | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

