# IO.Swagger.Api.CompteApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCompteItem**](CompteApi.md#deletecompteitem) | **DELETE** /PhotoBoothProject/comptes/{id} | Removes the Compte resource.
[**GetCompteCollection**](CompteApi.md#getcomptecollection) | **GET** /PhotoBoothProject/comptes | Retrieves the collection of Compte resources.
[**GetCompteItem**](CompteApi.md#getcompteitem) | **GET** /PhotoBoothProject/comptes/{id} | Retrieves a Compte resource.
[**PatchCompteItem**](CompteApi.md#patchcompteitem) | **PATCH** /PhotoBoothProject/comptes/{id} | Updates the Compte resource.
[**PostCompteCollection**](CompteApi.md#postcomptecollection) | **POST** /PhotoBoothProject/comptes | Creates a Compte resource.
[**PutCompteItem**](CompteApi.md#putcompteitem) | **PUT** /PhotoBoothProject/comptes/{id} | Replaces the Compte resource.

<a name="deletecompteitem"></a>
# **DeleteCompteItem**
> void DeleteCompteItem (string id)

Removes the Compte resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCompteItemExample
    {
        public void main()
        {
            var apiInstance = new CompteApi();
            var id = id_example;  // string | 

            try
            {
                // Removes the Compte resource.
                apiInstance.DeleteCompteItem(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompteApi.DeleteCompteItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcomptecollection"></a>
# **GetCompteCollection**
> Object GetCompteCollection (int? page = null)

Retrieves the collection of Compte resources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCompteCollectionExample
    {
        public void main()
        {
            var apiInstance = new CompteApi();
            var page = 56;  // int? | The collection page number (optional) 

            try
            {
                // Retrieves the collection of Compte resources.
                Object result = apiInstance.GetCompteCollection(page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompteApi.GetCompteCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The collection page number | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcompteitem"></a>
# **GetCompteItem**
> ComponentsschemasComptejsonld GetCompteItem (string id)

Retrieves a Compte resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCompteItemExample
    {
        public void main()
        {
            var apiInstance = new CompteApi();
            var id = id_example;  // string | 

            try
            {
                // Retrieves a Compte resource.
                ComponentsschemasComptejsonld result = apiInstance.GetCompteItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompteApi.GetCompteItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

[**ComponentsschemasComptejsonld**](ComponentsschemasComptejsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="patchcompteitem"></a>
# **PatchCompteItem**
> ComponentsschemasComptejsonld PatchCompteItem (string id, Compte body = null)

Updates the Compte resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchCompteItemExample
    {
        public void main()
        {
            var apiInstance = new CompteApi();
            var id = id_example;  // string | 
            var body = new Compte(); // Compte | The updated Compte resource (optional) 

            try
            {
                // Updates the Compte resource.
                ComponentsschemasComptejsonld result = apiInstance.PatchCompteItem(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompteApi.PatchCompteItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **body** | [**Compte**](Compte.md)| The updated Compte resource | [optional] 

### Return type

[**ComponentsschemasComptejsonld**](ComponentsschemasComptejsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/merge-patch+json
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postcomptecollection"></a>
# **PostCompteCollection**
> ComponentsschemasComptejsonld PostCompteCollection (Compte body = null)

Creates a Compte resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostCompteCollectionExample
    {
        public void main()
        {
            var apiInstance = new CompteApi();
            var body = new Compte(); // Compte | The new Compte resource (optional) 

            try
            {
                // Creates a Compte resource.
                ComponentsschemasComptejsonld result = apiInstance.PostCompteCollection(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompteApi.PostCompteCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Compte**](Compte.md)| The new Compte resource | [optional] 

### Return type

[**ComponentsschemasComptejsonld**](ComponentsschemasComptejsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/ld+json, application/json, text/html
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putcompteitem"></a>
# **PutCompteItem**
> ComponentsschemasComptejsonld PutCompteItem (string id, Compte body = null)

Replaces the Compte resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutCompteItemExample
    {
        public void main()
        {
            var apiInstance = new CompteApi();
            var id = id_example;  // string | 
            var body = new Compte(); // Compte | The updated Compte resource (optional) 

            try
            {
                // Replaces the Compte resource.
                ComponentsschemasComptejsonld result = apiInstance.PutCompteItem(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompteApi.PutCompteItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **body** | [**Compte**](Compte.md)| The updated Compte resource | [optional] 

### Return type

[**ComponentsschemasComptejsonld**](ComponentsschemasComptejsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/ld+json, application/json, text/html
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
