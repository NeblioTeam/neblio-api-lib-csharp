# IO.Swagger.Api.TestnetFaucetApi

All URIs are relative to *https://ntp1node.nebl.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TestnetGetFaucet**](TestnetFaucetApi.md#testnetgetfaucet) | **GET** /testnet/faucet | Withdraws testnet NEBL to the specified address


<a name="testnetgetfaucet"></a>
# **TestnetGetFaucet**
> GetFaucetResponse TestnetGetFaucet (string address, decimal? amount = null)

Withdraws testnet NEBL to the specified address

Withdraw testnet NEBL to your Neblio Testnet address. By default amount is 1500000000 or 15 NEBL and has a max of 50 NEBL. Only 2 withdrawals allowed per 24 hour period. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TestnetGetFaucetExample
    {
        public void main()
        {
            var apiInstance = new TestnetFaucetApi();
            var address = address_example;  // string | Your Neblio Testnet Address
            var amount = 8.14;  // decimal? | Amount of NEBL to withdrawal in satoshis (optional) 

            try
            {
                // Withdraws testnet NEBL to the specified address
                GetFaucetResponse result = apiInstance.TestnetGetFaucet(address, amount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TestnetFaucetApi.TestnetGetFaucet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Your Neblio Testnet Address | 
 **amount** | **decimal?**| Amount of NEBL to withdrawal in satoshis | [optional] 

### Return type

[**GetFaucetResponse**](GetFaucetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

