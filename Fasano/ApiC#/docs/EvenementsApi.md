# IO.Swagger.Api.EvenementsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteEvenementsItem**](EvenementsApi.md#deleteevenementsitem) | **DELETE** /PhotoBoothProject/evenements/{id} | Removes the Evenements resource.
[**GetEvenementsCollection**](EvenementsApi.md#getevenementscollection) | **GET** /PhotoBoothProject/evenements | Retrieves the collection of Evenements resources.
[**GetEvenementsItem**](EvenementsApi.md#getevenementsitem) | **GET** /PhotoBoothProject/evenements/{id} | Retrieves a Evenements resource.
[**PatchEvenementsItem**](EvenementsApi.md#patchevenementsitem) | **PATCH** /PhotoBoothProject/evenements/{id} | Updates the Evenements resource.
[**PostEvenementsCollection**](EvenementsApi.md#postevenementscollection) | **POST** /PhotoBoothProject/evenements | Creates a Evenements resource.
[**PutEvenementsItem**](EvenementsApi.md#putevenementsitem) | **PUT** /PhotoBoothProject/evenements/{id} | Replaces the Evenements resource.

<a name="deleteevenementsitem"></a>
# **DeleteEvenementsItem**
> void DeleteEvenementsItem (string id)

Removes the Evenements resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteEvenementsItemExample
    {
        public void main()
        {
            var apiInstance = new EvenementsApi();
            var id = id_example;  // string | 

            try
            {
                // Removes the Evenements resource.
                apiInstance.DeleteEvenementsItem(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EvenementsApi.DeleteEvenementsItem: " + e.Message );
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
<a name="getevenementscollection"></a>
# **GetEvenementsCollection**
> Object GetEvenementsCollection (int? page = null)

Retrieves the collection of Evenements resources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEvenementsCollectionExample
    {
        public void main()
        {
            var apiInstance = new EvenementsApi();
            var page = 56;  // int? | The collection page number (optional) 

            try
            {
                // Retrieves the collection of Evenements resources.
                Object result = apiInstance.GetEvenementsCollection(page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EvenementsApi.GetEvenementsCollection: " + e.Message );
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
<a name="getevenementsitem"></a>
# **GetEvenementsItem**
> ComponentsschemasEvenementsjsonld GetEvenementsItem (string id)

Retrieves a Evenements resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEvenementsItemExample
    {
        public void main()
        {
            var apiInstance = new EvenementsApi();
            var id = id_example;  // string | 

            try
            {
                // Retrieves a Evenements resource.
                ComponentsschemasEvenementsjsonld result = apiInstance.GetEvenementsItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EvenementsApi.GetEvenementsItem: " + e.Message );
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

[**ComponentsschemasEvenementsjsonld**](ComponentsschemasEvenementsjsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="patchevenementsitem"></a>
# **PatchEvenementsItem**
> ComponentsschemasEvenementsjsonld PatchEvenementsItem (string id, Evenements body = null)

Updates the Evenements resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchEvenementsItemExample
    {
        public void main()
        {
            var apiInstance = new EvenementsApi();
            var id = id_example;  // string | 
            var body = new Evenements(); // Evenements | The updated Evenements resource (optional) 

            try
            {
                // Updates the Evenements resource.
                ComponentsschemasEvenementsjsonld result = apiInstance.PatchEvenementsItem(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EvenementsApi.PatchEvenementsItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **body** | [**Evenements**](Evenements.md)| The updated Evenements resource | [optional] 

### Return type

[**ComponentsschemasEvenementsjsonld**](ComponentsschemasEvenementsjsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/merge-patch+json
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postevenementscollection"></a>
# **PostEvenementsCollection**
> ComponentsschemasEvenementsjsonld PostEvenementsCollection (Evenements body = null)

Creates a Evenements resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostEvenementsCollectionExample
    {
        public void main()
        {
            var apiInstance = new EvenementsApi();
            var body = new Evenements(); // Evenements | The new Evenements resource (optional) 

            try
            {
                // Creates a Evenements resource.
                ComponentsschemasEvenementsjsonld result = apiInstance.PostEvenementsCollection(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EvenementsApi.PostEvenementsCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Evenements**](Evenements.md)| The new Evenements resource | [optional] 

### Return type

[**ComponentsschemasEvenementsjsonld**](ComponentsschemasEvenementsjsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/ld+json, application/json, text/html
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putevenementsitem"></a>
# **PutEvenementsItem**
> ComponentsschemasEvenementsjsonld PutEvenementsItem (string id, Evenements body = null)

Replaces the Evenements resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutEvenementsItemExample
    {
        public void main()
        {
            var apiInstance = new EvenementsApi();
            var id = id_example;  // string | 
            var body = new Evenements(); // Evenements | The updated Evenements resource (optional) 

            try
            {
                // Replaces the Evenements resource.
                ComponentsschemasEvenementsjsonld result = apiInstance.PutEvenementsItem(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EvenementsApi.PutEvenementsItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **body** | [**Evenements**](Evenements.md)| The updated Evenements resource | [optional] 

### Return type

[**ComponentsschemasEvenementsjsonld**](ComponentsschemasEvenementsjsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/ld+json, application/json, text/html
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
