# Neblio.API.Api.TestnetNTP1Api

All URIs are relative to *https://ntp1node.nebl.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TestnetBroadcastTx**](TestnetNTP1Api.md#testnetbroadcasttx) | **POST** /testnet/ntp1/broadcast | Broadcasts a signed raw transaction to the network
[**TestnetBurnToken**](TestnetNTP1Api.md#testnetburntoken) | **POST** /testnet/ntp1/burntoken | Builds a transaction that burns an NTP1 Token
[**TestnetGetAddressInfo**](TestnetNTP1Api.md#testnetgetaddressinfo) | **GET** /testnet/ntp1/addressinfo/{address} | Information On a Neblio Address
[**TestnetGetTokenHolders**](TestnetNTP1Api.md#testnetgettokenholders) | **GET** /testnet/ntp1/stakeholders/{tokenid} | Get Addresses Holding a Token
[**TestnetGetTokenId**](TestnetNTP1Api.md#testnetgettokenid) | **GET** /testnet/ntp1/tokenid/{tokensymbol} | Returns the tokenId representing a token
[**TestnetGetTokenMetadataOfIssuance**](TestnetNTP1Api.md#testnetgettokenmetadataofissuance) | **GET** /testnet/ntp1/tokenmetadata/{tokenid} | Get Issuance Metadata of Token
[**TestnetGetTokenMetadataOfUtxo**](TestnetNTP1Api.md#testnetgettokenmetadataofutxo) | **GET** /testnet/ntp1/tokenmetadata/{tokenid}/{utxo} | Get UTXO Metadata of Token
[**TestnetGetTransactionInfo**](TestnetNTP1Api.md#testnetgettransactioninfo) | **GET** /testnet/ntp1/transactioninfo/{txid} | Information On an NTP1 Transaction
[**TestnetIssueToken**](TestnetNTP1Api.md#testnetissuetoken) | **POST** /testnet/ntp1/issue | Builds a transaction that issues a new NTP1 Token
[**TestnetSendToken**](TestnetNTP1Api.md#testnetsendtoken) | **POST** /testnet/ntp1/sendtoken | Builds a transaction that sends an NTP1 Token


<a name="testnetbroadcasttx"></a>
# **TestnetBroadcastTx**
> BroadcastTxResponse TestnetBroadcastTx (BroadcastTxRequest broadcastTxRequest)

Broadcasts a signed raw transaction to the network

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
    public class TestnetBroadcastTxExample
    {
        public void main()
        {
            var apiInstance = new TestnetNTP1Api();
            var broadcastTxRequest = new BroadcastTxRequest(); // BroadcastTxRequest | Object representing a transaction to broadcast

            try
            {
                // Broadcasts a signed raw transaction to the network
                BroadcastTxResponse result = apiInstance.TestnetBroadcastTx(broadcastTxRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestnetNTP1Api.TestnetBroadcastTx: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **broadcastTxRequest** | [**BroadcastTxRequest**](BroadcastTxRequest.md)| Object representing a transaction to broadcast | 

### Return type

[**BroadcastTxResponse**](BroadcastTxResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testnetburntoken"></a>
# **TestnetBurnToken**
> BurnTokenResponse TestnetBurnToken (BurnTokenRequest burnTokenRequest)

Builds a transaction that burns an NTP1 Token

Builds an unsigned raw transaction that burns an NTP1 token on the Neblio blockchain. 

### Example
```csharp
using System;
using System.Diagnostics;
using Neblio.API.Api;
using Neblio.API.Client;
using Neblio.API.Model;

namespace Example
{
    public class TestnetBurnTokenExample
    {
        public void main()
        {
            var apiInstance = new TestnetNTP1Api();
            var burnTokenRequest = new BurnTokenRequest(); // BurnTokenRequest | Object representing the token to be burned

            try
            {
                // Builds a transaction that burns an NTP1 Token
                BurnTokenResponse result = apiInstance.TestnetBurnToken(burnTokenRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestnetNTP1Api.TestnetBurnToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **burnTokenRequest** | [**BurnTokenRequest**](BurnTokenRequest.md)| Object representing the token to be burned | 

### Return type

[**BurnTokenResponse**](BurnTokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testnetgetaddressinfo"></a>
# **TestnetGetAddressInfo**
> GetAddressInfoResponse TestnetGetAddressInfo (string address)

Information On a Neblio Address

Returns both NEBL and NTP1 token UTXOs held at the given address. 

### Example
```csharp
using System;
using System.Diagnostics;
using Neblio.API.Api;
using Neblio.API.Client;
using Neblio.API.Model;

namespace Example
{
    public class TestnetGetAddressInfoExample
    {
        public void main()
        {
            var apiInstance = new TestnetNTP1Api();
            var address = address_example;  // string | Neblio Address to get information on.

            try
            {
                // Information On a Neblio Address
                GetAddressInfoResponse result = apiInstance.TestnetGetAddressInfo(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestnetNTP1Api.TestnetGetAddressInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Neblio Address to get information on. | 

### Return type

[**GetAddressInfoResponse**](GetAddressInfoResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testnetgettokenholders"></a>
# **TestnetGetTokenHolders**
> GetTokenHoldersResponse TestnetGetTokenHolders (string tokenid)

Get Addresses Holding a Token

Returns the the the addresses holding a token and how many tokens are held 

### Example
```csharp
using System;
using System.Diagnostics;
using Neblio.API.Api;
using Neblio.API.Client;
using Neblio.API.Model;

namespace Example
{
    public class TestnetGetTokenHoldersExample
    {
        public void main()
        {
            var apiInstance = new TestnetNTP1Api();
            var tokenid = tokenid_example;  // string | TokenId to request metadata for

            try
            {
                // Get Addresses Holding a Token
                GetTokenHoldersResponse result = apiInstance.TestnetGetTokenHolders(tokenid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestnetNTP1Api.TestnetGetTokenHolders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenid** | **string**| TokenId to request metadata for | 

### Return type

[**GetTokenHoldersResponse**](GetTokenHoldersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testnetgettokenid"></a>
# **TestnetGetTokenId**
> GetTokenIdResponse TestnetGetTokenId (string tokensymbol)

Returns the tokenId representing a token

Translates a token symbol to a tokenId if a token exists with that symbol on the network 

### Example
```csharp
using System;
using System.Diagnostics;
using Neblio.API.Api;
using Neblio.API.Client;
using Neblio.API.Model;

namespace Example
{
    public class TestnetGetTokenIdExample
    {
        public void main()
        {
            var apiInstance = new TestnetNTP1Api();
            var tokensymbol = tokensymbol_example;  // string | Token symbol

            try
            {
                // Returns the tokenId representing a token
                GetTokenIdResponse result = apiInstance.TestnetGetTokenId(tokensymbol);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestnetNTP1Api.TestnetGetTokenId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokensymbol** | **string**| Token symbol | 

### Return type

[**GetTokenIdResponse**](GetTokenIdResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testnetgettokenmetadataofissuance"></a>
# **TestnetGetTokenMetadataOfIssuance**
> GetTokenMetadataResponse TestnetGetTokenMetadataOfIssuance (string tokenid)

Get Issuance Metadata of Token

Returns the metadata associated with a token at time of issuance. 

### Example
```csharp
using System;
using System.Diagnostics;
using Neblio.API.Api;
using Neblio.API.Client;
using Neblio.API.Model;

namespace Example
{
    public class TestnetGetTokenMetadataOfIssuanceExample
    {
        public void main()
        {
            var apiInstance = new TestnetNTP1Api();
            var tokenid = tokenid_example;  // string | TokenId to request metadata for

            try
            {
                // Get Issuance Metadata of Token
                GetTokenMetadataResponse result = apiInstance.TestnetGetTokenMetadataOfIssuance(tokenid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestnetNTP1Api.TestnetGetTokenMetadataOfIssuance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenid** | **string**| TokenId to request metadata for | 

### Return type

[**GetTokenMetadataResponse**](GetTokenMetadataResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testnetgettokenmetadataofutxo"></a>
# **TestnetGetTokenMetadataOfUtxo**
> GetTokenMetadataResponse TestnetGetTokenMetadataOfUtxo (string tokenid, string utxo)

Get UTXO Metadata of Token

Returns the metadata associated with a token for that specific utxo instead of the issuance transaction. 

### Example
```csharp
using System;
using System.Diagnostics;
using Neblio.API.Api;
using Neblio.API.Client;
using Neblio.API.Model;

namespace Example
{
    public class TestnetGetTokenMetadataOfUtxoExample
    {
        public void main()
        {
            var apiInstance = new TestnetNTP1Api();
            var tokenid = tokenid_example;  // string | TokenId to request metadata for
            var utxo = utxo_example;  // string | Specific UTXO to request metadata for

            try
            {
                // Get UTXO Metadata of Token
                GetTokenMetadataResponse result = apiInstance.TestnetGetTokenMetadataOfUtxo(tokenid, utxo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestnetNTP1Api.TestnetGetTokenMetadataOfUtxo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenid** | **string**| TokenId to request metadata for | 
 **utxo** | **string**| Specific UTXO to request metadata for | 

### Return type

[**GetTokenMetadataResponse**](GetTokenMetadataResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testnetgettransactioninfo"></a>
# **TestnetGetTransactionInfo**
> GetTransactionInfoResponse TestnetGetTransactionInfo (string txid)

Information On an NTP1 Transaction

Returns detailed information regarding an NTP1 transaction. 

### Example
```csharp
using System;
using System.Diagnostics;
using Neblio.API.Api;
using Neblio.API.Client;
using Neblio.API.Model;

namespace Example
{
    public class TestnetGetTransactionInfoExample
    {
        public void main()
        {
            var apiInstance = new TestnetNTP1Api();
            var txid = txid_example;  // string | Neblio txid to get information on.

            try
            {
                // Information On an NTP1 Transaction
                GetTransactionInfoResponse result = apiInstance.TestnetGetTransactionInfo(txid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestnetNTP1Api.TestnetGetTransactionInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **txid** | **string**| Neblio txid to get information on. | 

### Return type

[**GetTransactionInfoResponse**](GetTransactionInfoResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testnetissuetoken"></a>
# **TestnetIssueToken**
> IssueTokenResponse TestnetIssueToken (IssueTokenRequest issueTokenRequest)

Builds a transaction that issues a new NTP1 Token

Builds an unsigned raw transaction that issues a new NTP1 token on the Neblio blockchain. 

### Example
```csharp
using System;
using System.Diagnostics;
using Neblio.API.Api;
using Neblio.API.Client;
using Neblio.API.Model;

namespace Example
{
    public class TestnetIssueTokenExample
    {
        public void main()
        {
            var apiInstance = new TestnetNTP1Api();
            var issueTokenRequest = new IssueTokenRequest(); // IssueTokenRequest | Object representing the token to be created

            try
            {
                // Builds a transaction that issues a new NTP1 Token
                IssueTokenResponse result = apiInstance.TestnetIssueToken(issueTokenRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestnetNTP1Api.TestnetIssueToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **issueTokenRequest** | [**IssueTokenRequest**](IssueTokenRequest.md)| Object representing the token to be created | 

### Return type

[**IssueTokenResponse**](IssueTokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testnetsendtoken"></a>
# **TestnetSendToken**
> SendTokenResponse TestnetSendToken (SendTokenRequest sendTokenRequest)

Builds a transaction that sends an NTP1 Token

Builds an unsigned raw transaction that sends an NTP1 token on the Neblio blockchain. 

### Example
```csharp
using System;
using System.Diagnostics;
using Neblio.API.Api;
using Neblio.API.Client;
using Neblio.API.Model;

namespace Example
{
    public class TestnetSendTokenExample
    {
        public void main()
        {
            var apiInstance = new TestnetNTP1Api();
            var sendTokenRequest = new SendTokenRequest(); // SendTokenRequest | Object representing the token to be sent

            try
            {
                // Builds a transaction that sends an NTP1 Token
                SendTokenResponse result = apiInstance.TestnetSendToken(sendTokenRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestnetNTP1Api.TestnetSendToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sendTokenRequest** | [**SendTokenRequest**](SendTokenRequest.md)| Object representing the token to be sent | 

### Return type

[**SendTokenResponse**](SendTokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

