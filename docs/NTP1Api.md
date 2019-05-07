# Neblio.API.Api.NTP1Api

All URIs are relative to *https://ntp1node.nebl.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BroadcastTx**](NTP1Api.md#broadcasttx) | **POST** /ntp1/broadcast | Broadcasts a signed raw transaction to the network
[**BurnToken**](NTP1Api.md#burntoken) | **POST** /ntp1/burntoken | Builds a transaction that burns an NTP1 Token
[**GetAddressInfo**](NTP1Api.md#getaddressinfo) | **GET** /ntp1/addressinfo/{address} | Information On a Neblio Address
[**GetTokenHolders**](NTP1Api.md#gettokenholders) | **GET** /ntp1/stakeholders/{tokenid} | Get Addresses Holding a Token
[**GetTokenId**](NTP1Api.md#gettokenid) | **GET** /ntp1/tokenid/{tokensymbol} | Returns the tokenId representing a token
[**GetTokenMetadata**](NTP1Api.md#gettokenmetadata) | **GET** /ntp1/tokenmetadata/{tokenid} | Get Metadata of Token
[**GetTokenMetadataOfUtxo**](NTP1Api.md#gettokenmetadataofutxo) | **GET** /ntp1/tokenmetadata/{tokenid}/{utxo} | Get UTXO Metadata of Token
[**GetTransactionInfo**](NTP1Api.md#gettransactioninfo) | **GET** /ntp1/transactioninfo/{txid} | Information On an NTP1 Transaction
[**IssueToken**](NTP1Api.md#issuetoken) | **POST** /ntp1/issue | Builds a transaction that issues a new NTP1 Token
[**SendToken**](NTP1Api.md#sendtoken) | **POST** /ntp1/sendtoken | Builds a transaction that sends an NTP1 Token


<a name="broadcasttx"></a>
# **BroadcastTx**
> BroadcastTxResponse BroadcastTx (BroadcastTxRequest broadcastTxRequest)

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
    public class BroadcastTxExample
    {
        public void main()
        {
            var apiInstance = new NTP1Api();
            var broadcastTxRequest = new BroadcastTxRequest(); // BroadcastTxRequest | Object representing a transaction to broadcast

            try
            {
                // Broadcasts a signed raw transaction to the network
                BroadcastTxResponse result = apiInstance.BroadcastTx(broadcastTxRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NTP1Api.BroadcastTx: " + e.Message );
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

<a name="burntoken"></a>
# **BurnToken**
> BurnTokenResponse BurnToken (BurnTokenRequest burnTokenRequest)

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
    public class BurnTokenExample
    {
        public void main()
        {
            var apiInstance = new NTP1Api();
            var burnTokenRequest = new BurnTokenRequest(); // BurnTokenRequest | Object representing the token to be burned

            try
            {
                // Builds a transaction that burns an NTP1 Token
                BurnTokenResponse result = apiInstance.BurnToken(burnTokenRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NTP1Api.BurnToken: " + e.Message );
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

<a name="getaddressinfo"></a>
# **GetAddressInfo**
> GetAddressInfoResponse GetAddressInfo (string address)

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
    public class GetAddressInfoExample
    {
        public void main()
        {
            var apiInstance = new NTP1Api();
            var address = address_example;  // string | Neblio Address to get information on.

            try
            {
                // Information On a Neblio Address
                GetAddressInfoResponse result = apiInstance.GetAddressInfo(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NTP1Api.GetAddressInfo: " + e.Message );
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

<a name="gettokenholders"></a>
# **GetTokenHolders**
> GetTokenHoldersResponse GetTokenHolders (string tokenid)

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
    public class GetTokenHoldersExample
    {
        public void main()
        {
            var apiInstance = new NTP1Api();
            var tokenid = tokenid_example;  // string | TokenId to request metadata for

            try
            {
                // Get Addresses Holding a Token
                GetTokenHoldersResponse result = apiInstance.GetTokenHolders(tokenid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NTP1Api.GetTokenHolders: " + e.Message );
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

<a name="gettokenid"></a>
# **GetTokenId**
> GetTokenIdResponse GetTokenId (string tokensymbol)

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
    public class GetTokenIdExample
    {
        public void main()
        {
            var apiInstance = new NTP1Api();
            var tokensymbol = tokensymbol_example;  // string | Token symbol

            try
            {
                // Returns the tokenId representing a token
                GetTokenIdResponse result = apiInstance.GetTokenId(tokensymbol);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NTP1Api.GetTokenId: " + e.Message );
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

<a name="gettokenmetadata"></a>
# **GetTokenMetadata**
> GetTokenMetadataResponse GetTokenMetadata (string tokenid)

Get Metadata of Token

Returns the metadata associated with a token. 

### Example
```csharp
using System;
using System.Diagnostics;
using Neblio.API.Api;
using Neblio.API.Client;
using Neblio.API.Model;

namespace Example
{
    public class GetTokenMetadataExample
    {
        public void main()
        {
            var apiInstance = new NTP1Api();
            var tokenid = tokenid_example;  // string | TokenId to request metadata for

            try
            {
                // Get Metadata of Token
                GetTokenMetadataResponse result = apiInstance.GetTokenMetadata(tokenid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NTP1Api.GetTokenMetadata: " + e.Message );
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

<a name="gettokenmetadataofutxo"></a>
# **GetTokenMetadataOfUtxo**
> GetTokenMetadataResponse GetTokenMetadataOfUtxo (string tokenid, string utxo)

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
    public class GetTokenMetadataOfUtxoExample
    {
        public void main()
        {
            var apiInstance = new NTP1Api();
            var tokenid = tokenid_example;  // string | TokenId to request metadata for
            var utxo = utxo_example;  // string | Specific UTXO to request metadata for

            try
            {
                // Get UTXO Metadata of Token
                GetTokenMetadataResponse result = apiInstance.GetTokenMetadataOfUtxo(tokenid, utxo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NTP1Api.GetTokenMetadataOfUtxo: " + e.Message );
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

<a name="gettransactioninfo"></a>
# **GetTransactionInfo**
> GetTransactionInfoResponse GetTransactionInfo (string txid)

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
    public class GetTransactionInfoExample
    {
        public void main()
        {
            var apiInstance = new NTP1Api();
            var txid = txid_example;  // string | Neblio txid to get information on.

            try
            {
                // Information On an NTP1 Transaction
                GetTransactionInfoResponse result = apiInstance.GetTransactionInfo(txid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NTP1Api.GetTransactionInfo: " + e.Message );
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

<a name="issuetoken"></a>
# **IssueToken**
> IssueTokenResponse IssueToken (IssueTokenRequest issueTokenRequest)

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
    public class IssueTokenExample
    {
        public void main()
        {
            var apiInstance = new NTP1Api();
            var issueTokenRequest = new IssueTokenRequest(); // IssueTokenRequest | Object representing the token to be created

            try
            {
                // Builds a transaction that issues a new NTP1 Token
                IssueTokenResponse result = apiInstance.IssueToken(issueTokenRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NTP1Api.IssueToken: " + e.Message );
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

<a name="sendtoken"></a>
# **SendToken**
> SendTokenResponse SendToken (SendTokenRequest sendTokenRequest)

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
    public class SendTokenExample
    {
        public void main()
        {
            var apiInstance = new NTP1Api();
            var sendTokenRequest = new SendTokenRequest(); // SendTokenRequest | Object representing the token to be sent

            try
            {
                // Builds a transaction that sends an NTP1 Token
                SendTokenResponse result = apiInstance.SendToken(sendTokenRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NTP1Api.SendToken: " + e.Message );
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

