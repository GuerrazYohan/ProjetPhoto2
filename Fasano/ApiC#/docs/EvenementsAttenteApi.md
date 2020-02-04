# IO.Swagger.Api.EvenementsAttenteApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteEvenementsAttenteItem**](EvenementsAttenteApi.md#deleteevenementsattenteitem) | **DELETE** /PhotoBoothProject/evenements_attentes/{id} | Removes the EvenementsAttente resource.
[**GetEvenementsAttenteCollection**](EvenementsAttenteApi.md#getevenementsattentecollection) | **GET** /PhotoBoothProject/evenements_attentes | Retrieves the collection of EvenementsAttente resources.
[**GetEvenementsAttenteItem**](EvenementsAttenteApi.md#getevenementsattenteitem) | **GET** /PhotoBoothProject/evenements_attentes/{id} | Retrieves a EvenementsAttente resource.
[**PatchEvenementsAttenteItem**](EvenementsAttenteApi.md#patchevenementsattenteitem) | **PATCH** /PhotoBoothProject/evenements_attentes/{id} | Updates the EvenementsAttente resource.
[**PostEvenementsAttenteCollection**](EvenementsAttenteApi.md#postevenementsattentecollection) | **POST** /PhotoBoothProject/evenements_attentes | Creates a EvenementsAttente resource.
[**PutEvenementsAttenteItem**](EvenementsAttenteApi.md#putevenementsattenteitem) | **PUT** /PhotoBoothProject/evenements_attentes/{id} | Replaces the EvenementsAttente resource.

<a name="deleteevenementsattenteitem"></a>
# **DeleteEvenementsAttenteItem**
> void DeleteEvenementsAttenteItem (string id)

Removes the EvenementsAttente resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteEvenementsAttenteItemExample
    {
        public void main()
        {
            var apiInstance = new EvenementsAttenteApi();
            var id = id_example;  // string | 

            try
            {
                // Removes the EvenementsAttente resource.
                apiInstance.DeleteEvenementsAttenteItem(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EvenementsAttenteApi.DeleteEvenementsAttenteItem: " + e.Message );
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
<a name="getevenementsattentecollection"></a>
# **GetEvenementsAttenteCollection**
> Object GetEvenementsAttenteCollection (int? page = null)

Retrieves the collection of EvenementsAttente resources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEvenementsAttenteCollectionExample
    {
        public void main()
        {
            var apiInstance = new EvenementsAttenteApi();
            var page = 56;  // int? | The collection page number (optional) 

            try
            {
                // Retrieves the collection of EvenementsAttente resources.
                Object result = apiInstance.GetEvenementsAttenteCollection(page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EvenementsAttenteApi.GetEvenementsAttenteCollection: " + e.Message );
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
<a name="getevenementsattenteitem"></a>
# **GetEvenementsAttenteItem**
> ComponentsschemasEvenementsAttentejsonld GetEvenementsAttenteItem (string id)

Retrieves a EvenementsAttente resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEvenementsAttenteItemExample
    {
        public void main()
        {
            var apiInstance = new EvenementsAttenteApi();
            var id = id_example;  // string | 

            try
            {
                // Retrieves a EvenementsAttente resource.
                ComponentsschemasEvenementsAttentejsonld result = apiInstance.GetEvenementsAttenteItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EvenementsAttenteApi.GetEvenementsAttenteItem: " + e.Message );
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

[**ComponentsschemasEvenementsAttentejsonld**](ComponentsschemasEvenementsAttentejsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="patchevenementsattenteitem"></a>
# **PatchEvenementsAttenteItem**
> ComponentsschemasEvenementsAttentejsonld PatchEvenementsAttenteItem (string id, EvenementsAttente body = null)

Updates the EvenementsAttente resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchEvenementsAttenteItemExample
    {
        public void main()
        {
            var apiInstance = new EvenementsAttenteApi();
            var id = id_example;  // string | 
            var body = new EvenementsAttente(); // EvenementsAttente | The updated EvenementsAttente resource (optional) 

            try
            {
                // Updates the EvenementsAttente resource.
                ComponentsschemasEvenementsAttentejsonld result = apiInstance.PatchEvenementsAttenteItem(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EvenementsAttenteApi.PatchEvenementsAttenteItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **body** | [**EvenementsAttente**](EvenementsAttente.md)| The updated EvenementsAttente resource | [optional] 

### Return type

[**ComponentsschemasEvenementsAttentejsonld**](ComponentsschemasEvenementsAttentejsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/merge-patch+json
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postevenementsattentecollection"></a>
# **PostEvenementsAttenteCollection**
> ComponentsschemasEvenementsAttentejsonld PostEvenementsAttenteCollection (EvenementsAttente body = null)

Creates a EvenementsAttente resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostEvenementsAttenteCollectionExample
    {
        public void main()
        {
            var apiInstance = new EvenementsAttenteApi();
            var body = new EvenementsAttente(); // EvenementsAttente | The new EvenementsAttente resource (optional) 

            try
            {
                // Creates a EvenementsAttente resource.
                ComponentsschemasEvenementsAttentejsonld result = apiInstance.PostEvenementsAttenteCollection(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EvenementsAttenteApi.PostEvenementsAttenteCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EvenementsAttente**](EvenementsAttente.md)| The new EvenementsAttente resource | [optional] 

### Return type

[**ComponentsschemasEvenementsAttentejsonld**](ComponentsschemasEvenementsAttentejsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/ld+json, application/json, text/html
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putevenementsattenteitem"></a>
# **PutEvenementsAttenteItem**
> ComponentsschemasEvenementsAttentejsonld PutEvenementsAttenteItem (string id, EvenementsAttente body = null)

Replaces the EvenementsAttente resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutEvenementsAttenteItemExample
    {
        public void main()
        {
            var apiInstance = new EvenementsAttenteApi();
            var id = id_example;  // string | 
            var body = new EvenementsAttente(); // EvenementsAttente | The updated EvenementsAttente resource (optional) 

            try
            {
                // Replaces the EvenementsAttente resource.
                ComponentsschemasEvenementsAttentejsonld result = apiInstance.PutEvenementsAttenteItem(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EvenementsAttenteApi.PutEvenementsAttenteItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **body** | [**EvenementsAttente**](EvenementsAttente.md)| The updated EvenementsAttente resource | [optional] 

### Return type

[**ComponentsschemasEvenementsAttentejsonld**](ComponentsschemasEvenementsAttentejsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/ld+json, application/json, text/html
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
