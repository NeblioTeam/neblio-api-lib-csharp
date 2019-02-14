# Neblio.API.Api.TestnetInsightApi

All URIs are relative to *https://ntp1node.nebl.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TestnetGetAddress**](TestnetInsightApi.md#testnetgetaddress) | **GET** /testnet/ins/addr/{address} | Returns address object
[**TestnetGetAddressBalance**](TestnetInsightApi.md#testnetgetaddressbalance) | **GET** /testnet/ins/addr/{address}/balance | Returns address balance in sats
[**TestnetGetAddressTotalReceived**](TestnetInsightApi.md#testnetgetaddresstotalreceived) | **GET** /testnet/ins/addr/{address}/totalReceived | Returns total received by address in sats
[**TestnetGetAddressTotalSent**](TestnetInsightApi.md#testnetgetaddresstotalsent) | **GET** /testnet/ins/addr/{address}/totalSent | Returns total sent by address in sats
[**TestnetGetAddressUnconfirmedBalance**](TestnetInsightApi.md#testnetgetaddressunconfirmedbalance) | **GET** /testnet/ins/addr/{address}/unconfirmedBalance | Returns address unconfirmed balance in sats
[**TestnetGetAddressUtxos**](TestnetInsightApi.md#testnetgetaddressutxos) | **GET** /testnet/ins/addr/{address}/utxo | Returns all UTXOs at a given address
[**TestnetGetBlock**](TestnetInsightApi.md#testnetgetblock) | **GET** /testnet/ins/block/{blockhash} | Returns information regarding a Neblio block
[**TestnetGetBlockIndex**](TestnetInsightApi.md#testnetgetblockindex) | **GET** /testnet/ins/block-index/{blockindex} | Returns block hash of block
[**TestnetGetRawTx**](TestnetInsightApi.md#testnetgetrawtx) | **GET** /testnet/ins/rawtx/{txid} | Returns raw transaction hex
[**TestnetGetStatus**](TestnetInsightApi.md#testnetgetstatus) | **GET** /testnet/ins/status | Utility API for calling several blockchain node functions
[**TestnetGetSync**](TestnetInsightApi.md#testnetgetsync) | **GET** /testnet/ins/sync | Get node sync status
[**TestnetGetTx**](TestnetInsightApi.md#testnetgettx) | **GET** /testnet/ins/tx/{txid} | Returns transaction object
[**TestnetGetTxs**](TestnetInsightApi.md#testnetgettxs) | **GET** /testnet/ins/txs | Get transactions by block or address
[**TestnetSendTx**](TestnetInsightApi.md#testnetsendtx) | **POST** /testnet/ins/tx/send | Broadcasts a signed raw transaction to the network (not NTP1 specific)


<a name="testnetgetaddress"></a>
# **TestnetGetAddress**
> GetAddressResponse TestnetGetAddress (string address)

Returns address object

Returns NEBL address object containing information on a specific address

### Example
```csharp
using System;
using System.Diagnostics;
using Neblio.API.Api;
using Neblio.API.Client;
using Neblio.API.Model;

namespace Example
{
    public class TestnetGetAddressExample
    {
        public void main()
        {
            var apiInstance = new TestnetInsightApi();
            var address = address_example;  // string | Address

            try
            {
                // Returns address object
                GetAddressResponse result = apiInstance.TestnetGetAddress(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestnetInsightApi.TestnetGetAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Address | 

### Return type

[**GetAddressResponse**](GetAddressResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testnetgetaddressbalance"></a>
# **TestnetGetAddressBalance**
> decimal? TestnetGetAddressBalance (string address)

Returns address balance in sats

Returns NEBL address balance in satoshis

### Example
```csharp
using System;
using System.Diagnostics;
using Neblio.API.Api;
using Neblio.API.Client;
using Neblio.API.Model;

namespace Example
{
    public class TestnetGetAddressBalanceExample
    {
        public void main()
        {
            var apiInstance = new TestnetInsightApi();
            var address = address_example;  // string | Address

            try
            {
                // Returns address balance in sats
                decimal? result = apiInstance.TestnetGetAddressBalance(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestnetInsightApi.TestnetGetAddressBalance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Address | 

### Return type

**decimal?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testnetgetaddresstotalreceived"></a>
# **TestnetGetAddressTotalReceived**
> decimal? TestnetGetAddressTotalReceived (string address)

Returns total received by address in sats

Returns total NEBL received by address in satoshis

### Example
```csharp
using System;
using System.Diagnostics;
using Neblio.API.Api;
using Neblio.API.Client;
using Neblio.API.Model;

namespace Example
{
    public class TestnetGetAddressTotalReceivedExample
    {
        public void main()
        {
            var apiInstance = new TestnetInsightApi();
            var address = address_example;  // string | Address

            try
            {
                // Returns total received by address in sats
                decimal? result = apiInstance.TestnetGetAddressTotalReceived(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestnetInsightApi.TestnetGetAddressTotalReceived: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Address | 

### Return type

**decimal?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testnetgetaddresstotalsent"></a>
# **TestnetGetAddressTotalSent**
> decimal? TestnetGetAddressTotalSent (string address)

Returns total sent by address in sats

Returns total NEBL sent by address in satoshis

### Example
```csharp
using System;
using System.Diagnostics;
using Neblio.API.Api;
using Neblio.API.Client;
using Neblio.API.Model;

namespace Example
{
    public class TestnetGetAddressTotalSentExample
    {
        public void main()
        {
            var apiInstance = new TestnetInsightApi();
            var address = address_example;  // string | Address

            try
            {
                // Returns total sent by address in sats
                decimal? result = apiInstance.TestnetGetAddressTotalSent(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestnetInsightApi.TestnetGetAddressTotalSent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Address | 

### Return type

**decimal?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testnetgetaddressunconfirmedbalance"></a>
# **TestnetGetAddressUnconfirmedBalance**
> decimal? TestnetGetAddressUnconfirmedBalance (string address)

Returns address unconfirmed balance in sats

Returns NEBL address unconfirmed balance in satoshis

### Example
```csharp
using System;
using System.Diagnostics;
using Neblio.API.Api;
using Neblio.API.Client;
using Neblio.API.Model;

namespace Example
{
    public class TestnetGetAddressUnconfirmedBalanceExample
    {
        public void main()
        {
            var apiInstance = new TestnetInsightApi();
            var address = address_example;  // string | Address

            try
            {
                // Returns address unconfirmed balance in sats
                decimal? result = apiInstance.TestnetGetAddressUnconfirmedBalance(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestnetInsightApi.TestnetGetAddressUnconfirmedBalance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Address | 

### Return type

**decimal?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testnetgetaddressutxos"></a>
# **TestnetGetAddressUtxos**
> List<Object> TestnetGetAddressUtxos (string address)

Returns all UTXOs at a given address

Returns information on each Unspent Transaction Output contained at an address

### Example
```csharp
using System;
using System.Diagnostics;
using Neblio.API.Api;
using Neblio.API.Client;
using Neblio.API.Model;

namespace Example
{
    public class TestnetGetAddressUtxosExample
    {
        public void main()
        {
            var apiInstance = new TestnetInsightApi();
            var address = address_example;  // string | Address

            try
            {
                // Returns all UTXOs at a given address
                List&lt;Object&gt; result = apiInstance.TestnetGetAddressUtxos(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestnetInsightApi.TestnetGetAddressUtxos: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Address | 

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testnetgetblock"></a>
# **TestnetGetBlock**
> GetBlockResponse TestnetGetBlock (string blockhash)

Returns information regarding a Neblio block

Returns blockchain data for a given block based upon the block hash

### Example
```csharp
using System;
using System.Diagnostics;
using Neblio.API.Api;
using Neblio.API.Client;
using Neblio.API.Model;

namespace Example
{
    public class TestnetGetBlockExample
    {
        public void main()
        {
            var apiInstance = new TestnetInsightApi();
            var blockhash = blockhash_example;  // string | Block Hash

            try
            {
                // Returns information regarding a Neblio block
                GetBlockResponse result = apiInstance.TestnetGetBlock(blockhash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestnetInsightApi.TestnetGetBlock: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **blockhash** | **string**| Block Hash | 

### Return type

[**GetBlockResponse**](GetBlockResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testnetgetblockindex"></a>
# **TestnetGetBlockIndex**
> GetBlockIndexResponse TestnetGetBlockIndex (decimal? blockindex)

Returns block hash of block

Returns the block hash of a block at a given block index

### Example
```csharp
using System;
using System.Diagnostics;
using Neblio.API.Api;
using Neblio.API.Client;
using Neblio.API.Model;

namespace Example
{
    public class TestnetGetBlockIndexExample
    {
        public void main()
        {
            var apiInstance = new TestnetInsightApi();
            var blockindex = 8.14;  // decimal? | Block Index

            try
            {
                // Returns block hash of block
                GetBlockIndexResponse result = apiInstance.TestnetGetBlockIndex(blockindex);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestnetInsightApi.TestnetGetBlockIndex: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **blockindex** | **decimal?**| Block Index | 

### Return type

[**GetBlockIndexResponse**](GetBlockIndexResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testnetgetrawtx"></a>
# **TestnetGetRawTx**
> GetRawTxResponse TestnetGetRawTx (string txid)

Returns raw transaction hex

Returns raw transaction hex representing a NEBL transaction

### Example
```csharp
using System;
using System.Diagnostics;
using Neblio.API.Api;
using Neblio.API.Client;
using Neblio.API.Model;

namespace Example
{
    public class TestnetGetRawTxExample
    {
        public void main()
        {
            var apiInstance = new TestnetInsightApi();
            var txid = txid_example;  // string | Transaction ID

            try
            {
                // Returns raw transaction hex
                GetRawTxResponse result = apiInstance.TestnetGetRawTx(txid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestnetInsightApi.TestnetGetRawTx: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **txid** | **string**| Transaction ID | 

### Return type

[**GetRawTxResponse**](GetRawTxResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testnetgetstatus"></a>
# **TestnetGetStatus**
> Object TestnetGetStatus (string q = null)

Utility API for calling several blockchain node functions

Utility API for calling several blockchain node functions - getInfo, getDifficulty, getBestBlockHash, getLastBlockHash

### Example
```csharp
using System;
using System.Diagnostics;
using Neblio.API.Api;
using Neblio.API.Client;
using Neblio.API.Model;

namespace Example
{
    public class TestnetGetStatusExample
    {
        public void main()
        {
            var apiInstance = new TestnetInsightApi();
            var q = q_example;  // string | Function to call, getInfo, getDifficulty, getBestBlockHash, or getLastBlockHash (optional) 

            try
            {
                // Utility API for calling several blockchain node functions
                Object result = apiInstance.TestnetGetStatus(q);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestnetInsightApi.TestnetGetStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| Function to call, getInfo, getDifficulty, getBestBlockHash, or getLastBlockHash | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testnetgetsync"></a>
# **TestnetGetSync**
> GetSyncResponse TestnetGetSync ()

Get node sync status

Returns information on the node's sync progress

### Example
```csharp
using System;
using System.Diagnostics;
using Neblio.API.Api;
using Neblio.API.Client;
using Neblio.API.Model;

namespace Example
{
    public class TestnetGetSyncExample
    {
        public void main()
        {
            var apiInstance = new TestnetInsightApi();

            try
            {
                // Get node sync status
                GetSyncResponse result = apiInstance.TestnetGetSync();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestnetInsightApi.TestnetGetSync: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GetSyncResponse**](GetSyncResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testnetgettx"></a>
# **TestnetGetTx**
> GetTxResponse TestnetGetTx (string txid)

Returns transaction object

Returns NEBL transaction object representing a NEBL transaction

### Example
```csharp
using System;
using System.Diagnostics;
using Neblio.API.Api;
using Neblio.API.Client;
using Neblio.API.Model;

namespace Example
{
    public class TestnetGetTxExample
    {
        public void main()
        {
            var apiInstance = new TestnetInsightApi();
            var txid = txid_example;  // string | Transaction ID

            try
            {
                // Returns transaction object
                GetTxResponse result = apiInstance.TestnetGetTx(txid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestnetInsightApi.TestnetGetTx: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **txid** | **string**| Transaction ID | 

### Return type

[**GetTxResponse**](GetTxResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testnetgettxs"></a>
# **TestnetGetTxs**
> GetTxsResponse TestnetGetTxs (string address = null, string block = null, decimal? pageNum = null)

Get transactions by block or address

Returns all transactions by block or address

### Example
```csharp
using System;
using System.Diagnostics;
using Neblio.API.Api;
using Neblio.API.Client;
using Neblio.API.Model;

namespace Example
{
    public class TestnetGetTxsExample
    {
        public void main()
        {
            var apiInstance = new TestnetInsightApi();
            var address = address_example;  // string | Address (optional) 
            var block = block_example;  // string | Block Hash (optional) 
            var pageNum = 8.14;  // decimal? | Page number to display (optional) 

            try
            {
                // Get transactions by block or address
                GetTxsResponse result = apiInstance.TestnetGetTxs(address, block, pageNum);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestnetInsightApi.TestnetGetTxs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Address | [optional] 
 **block** | **string**| Block Hash | [optional] 
 **pageNum** | **decimal?**| Page number to display | [optional] 

### Return type

[**GetTxsResponse**](GetTxsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testnetsendtx"></a>
# **TestnetSendTx**
> BroadcastTxResponse TestnetSendTx (SendTxRequest body)

Broadcasts a signed raw transaction to the network (not NTP1 specific)

Broadcasts a signed raw transaction to the network. If successful returns the txid of the broadcast trasnaction. 

### Example
```csharp
using System;
using System.Diagnostics;
using Neblio.API.Api;
using Neblio.API.Client;
using Neblio.API.Model;

namespace Example
{
    public class TestnetSendTxExample
    {
        public void main()
        {
            var apiInstance = new TestnetInsightApi();
            var body = new SendTxRequest(); // SendTxRequest | Object representing a transaction to broadcast

            try
            {
                // Broadcasts a signed raw transaction to the network (not NTP1 specific)
                BroadcastTxResponse result = apiInstance.TestnetSendTx(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestnetInsightApi.TestnetSendTx: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SendTxRequest**](SendTxRequest.md)| Object representing a transaction to broadcast | 

### Return type

[**BroadcastTxResponse**](BroadcastTxResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

