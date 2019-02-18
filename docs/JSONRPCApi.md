# Neblio.API.Api.JSONRPCApi

All URIs are relative to *https://ntp1node.nebl.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RPC**](JSONRPCApi.md#rpc) | **POST** / | Send a JSON-RPC call to a localhost neblio-Qt or nebliod node


<a name="rpc"></a>
# **RPC**
> RpcResponse RPC (RpcRequest rpcRequest)

Send a JSON-RPC call to a localhost neblio-Qt or nebliod node

Call any Neblio RPC command from the Neblio API libraries. Useful for signing transactions with a local node and other functions. Will not work from this page due to CORS restrictions. Requires a node to be running locally at 127.0.0.1 - Use port 16326 for testnet.

### Example
```csharp
using System;
using System.Diagnostics;
using Neblio.API.Api;
using Neblio.API.Client;
using Neblio.API.Model;

namespace Example
{
    public class RPCExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: rpcAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new JSONRPCApi();
            var rpcRequest = new RpcRequest(); // RpcRequest | 

            try
            {
                // Send a JSON-RPC call to a localhost neblio-Qt or nebliod node
                RpcResponse result = apiInstance.RPC(rpcRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JSONRPCApi.RPC: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rpcRequest** | [**RpcRequest**](RpcRequest.md)|  | 

### Return type

[**RpcResponse**](RpcResponse.md)

### Authorization

[rpcAuth](../README.md#rpcAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

