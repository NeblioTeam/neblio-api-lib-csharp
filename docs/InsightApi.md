# Neblio.API.Api.InsightApi

All URIs are relative to *https://ntp1node.nebl.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAddress**](InsightApi.md#getaddress) | **GET** /ins/addr/{address} | Returns address object
[**GetAddressBalance**](InsightApi.md#getaddressbalance) | **GET** /ins/addr/{address}/balance | Returns address balance in sats
[**GetAddressTotalReceived**](InsightApi.md#getaddresstotalreceived) | **GET** /ins/addr/{address}/totalReceived | Returns total received by address in sats
[**GetAddressTotalSent**](InsightApi.md#getaddresstotalsent) | **GET** /ins/addr/{address}/totalSent | Returns total sent by address in sats
[**GetAddressUnconfirmedBalance**](InsightApi.md#getaddressunconfirmedbalance) | **GET** /ins/addr/{address}/unconfirmedBalance | Returns address unconfirmed balance in sats
[**GetAddressUtxos**](InsightApi.md#getaddressutxos) | **GET** /ins/addr/{address}/utxo | Returns all UTXOs at a given address
[**GetBlock**](InsightApi.md#getblock) | **GET** /ins/block/{blockhash} | Returns information regarding a Neblio block
[**GetBlockIndex**](InsightApi.md#getblockindex) | **GET** /ins/block-index/{blockindex} | Returns block hash of block
[**GetRawTx**](InsightApi.md#getrawtx) | **GET** /ins/rawtx/{txid} | Returns raw transaction hex
[**GetStatus**](InsightApi.md#getstatus) | **GET** /ins/status | Utility API for calling several blockchain node functions
[**GetSync**](InsightApi.md#getsync) | **GET** /ins/sync | Get node sync status
[**GetTx**](InsightApi.md#gettx) | **GET** /ins/tx/{txid} | Returns transaction object
[**GetTxs**](InsightApi.md#gettxs) | **GET** /ins/txs | Get transactions by block or address
[**SendTx**](InsightApi.md#sendtx) | **POST** /ins/tx/send | Broadcasts a signed raw transaction to the network (not NTP1 specific)


<a name="getaddress"></a>
# **GetAddress**
> GetAddressResponse GetAddress (string address)

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
    public class GetAddressExample
    {
        public void main()
        {
            var apiInstance = new InsightApi();
            var address = address_example;  // string | Address

            try
            {
                // Returns address object
                GetAddressResponse result = apiInstance.GetAddress(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InsightApi.GetAddress: " + e.Message );
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

<a name="getaddressbalance"></a>
# **GetAddressBalance**
> decimal? GetAddressBalance (string address)

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
    public class GetAddressBalanceExample
    {
        public void main()
        {
            var apiInstance = new InsightApi();
            var address = address_example;  // string | Address

            try
            {
                // Returns address balance in sats
                decimal? result = apiInstance.GetAddressBalance(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InsightApi.GetAddressBalance: " + e.Message );
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

<a name="getaddresstotalreceived"></a>
# **GetAddressTotalReceived**
> decimal? GetAddressTotalReceived (string address)

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
    public class GetAddressTotalReceivedExample
    {
        public void main()
        {
            var apiInstance = new InsightApi();
            var address = address_example;  // string | Address

            try
            {
                // Returns total received by address in sats
                decimal? result = apiInstance.GetAddressTotalReceived(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InsightApi.GetAddressTotalReceived: " + e.Message );
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

<a name="getaddresstotalsent"></a>
# **GetAddressTotalSent**
> decimal? GetAddressTotalSent (string address)

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
    public class GetAddressTotalSentExample
    {
        public void main()
        {
            var apiInstance = new InsightApi();
            var address = address_example;  // string | Address

            try
            {
                // Returns total sent by address in sats
                decimal? result = apiInstance.GetAddressTotalSent(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InsightApi.GetAddressTotalSent: " + e.Message );
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

<a name="getaddressunconfirmedbalance"></a>
# **GetAddressUnconfirmedBalance**
> decimal? GetAddressUnconfirmedBalance (string address)

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
    public class GetAddressUnconfirmedBalanceExample
    {
        public void main()
        {
            var apiInstance = new InsightApi();
            var address = address_example;  // string | Address

            try
            {
                // Returns address unconfirmed balance in sats
                decimal? result = apiInstance.GetAddressUnconfirmedBalance(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InsightApi.GetAddressUnconfirmedBalance: " + e.Message );
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

<a name="getaddressutxos"></a>
# **GetAddressUtxos**
> List<Object> GetAddressUtxos (string address)

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
    public class GetAddressUtxosExample
    {
        public void main()
        {
            var apiInstance = new InsightApi();
            var address = address_example;  // string | Address

            try
            {
                // Returns all UTXOs at a given address
                List&lt;Object&gt; result = apiInstance.GetAddressUtxos(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InsightApi.GetAddressUtxos: " + e.Message );
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

<a name="getblock"></a>
# **GetBlock**
> GetBlockResponse GetBlock (string blockhash)

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
    public class GetBlockExample
    {
        public void main()
        {
            var apiInstance = new InsightApi();
            var blockhash = blockhash_example;  // string | Block Hash

            try
            {
                // Returns information regarding a Neblio block
                GetBlockResponse result = apiInstance.GetBlock(blockhash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InsightApi.GetBlock: " + e.Message );
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

<a name="getblockindex"></a>
# **GetBlockIndex**
> GetBlockIndexResponse GetBlockIndex (decimal? blockindex)

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
    public class GetBlockIndexExample
    {
        public void main()
        {
            var apiInstance = new InsightApi();
            var blockindex = 8.14;  // decimal? | Block Index

            try
            {
                // Returns block hash of block
                GetBlockIndexResponse result = apiInstance.GetBlockIndex(blockindex);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InsightApi.GetBlockIndex: " + e.Message );
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

<a name="getrawtx"></a>
# **GetRawTx**
> GetRawTxResponse GetRawTx (string txid)

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
    public class GetRawTxExample
    {
        public void main()
        {
            var apiInstance = new InsightApi();
            var txid = txid_example;  // string | Transaction ID

            try
            {
                // Returns raw transaction hex
                GetRawTxResponse result = apiInstance.GetRawTx(txid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InsightApi.GetRawTx: " + e.Message );
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

<a name="getstatus"></a>
# **GetStatus**
> Object GetStatus (string q = null)

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
    public class GetStatusExample
    {
        public void main()
        {
            var apiInstance = new InsightApi();
            var q = q_example;  // string | Function to call, getInfo, getDifficulty, getBestBlockHash, or getLastBlockHash (optional) 

            try
            {
                // Utility API for calling several blockchain node functions
                Object result = apiInstance.GetStatus(q);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InsightApi.GetStatus: " + e.Message );
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

<a name="getsync"></a>
# **GetSync**
> GetSyncResponse GetSync ()

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
    public class GetSyncExample
    {
        public void main()
        {
            var apiInstance = new InsightApi();

            try
            {
                // Get node sync status
                GetSyncResponse result = apiInstance.GetSync();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InsightApi.GetSync: " + e.Message );
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

<a name="gettx"></a>
# **GetTx**
> GetTxResponse GetTx (string txid)

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
    public class GetTxExample
    {
        public void main()
        {
            var apiInstance = new InsightApi();
            var txid = txid_example;  // string | Transaction ID

            try
            {
                // Returns transaction object
                GetTxResponse result = apiInstance.GetTx(txid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InsightApi.GetTx: " + e.Message );
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

<a name="gettxs"></a>
# **GetTxs**
> GetTxsResponse GetTxs (string address = null, string block = null, decimal? pageNum = null)

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
    public class GetTxsExample
    {
        public void main()
        {
            var apiInstance = new InsightApi();
            var address = address_example;  // string | Address (optional) 
            var block = block_example;  // string | Block Hash (optional) 
            var pageNum = 8.14;  // decimal? | Page number to display (optional) 

            try
            {
                // Get transactions by block or address
                GetTxsResponse result = apiInstance.GetTxs(address, block, pageNum);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InsightApi.GetTxs: " + e.Message );
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

<a name="sendtx"></a>
# **SendTx**
> BroadcastTxResponse SendTx (SendTxRequest body)

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
    public class SendTxExample
    {
        public void main()
        {
            var apiInstance = new InsightApi();
            var body = new SendTxRequest(); // SendTxRequest | Object representing a transaction to broadcast

            try
            {
                // Broadcasts a signed raw transaction to the network (not NTP1 specific)
                BroadcastTxResponse result = apiInstance.SendTx(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InsightApi.SendTx: " + e.Message );
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

