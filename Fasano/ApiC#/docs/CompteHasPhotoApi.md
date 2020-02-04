# IO.Swagger.Api.CompteHasPhotoApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCompteHasPhotoItem**](CompteHasPhotoApi.md#deletecomptehasphotoitem) | **DELETE** /PhotoBoothProject/compte_has_photos/{id} | Removes the CompteHasPhoto resource.
[**GetCompteHasPhotoCollection**](CompteHasPhotoApi.md#getcomptehasphotocollection) | **GET** /PhotoBoothProject/compte_has_photos | Retrieves the collection of CompteHasPhoto resources.
[**GetCompteHasPhotoItem**](CompteHasPhotoApi.md#getcomptehasphotoitem) | **GET** /PhotoBoothProject/compte_has_photos/{id} | Retrieves a CompteHasPhoto resource.
[**PatchCompteHasPhotoItem**](CompteHasPhotoApi.md#patchcomptehasphotoitem) | **PATCH** /PhotoBoothProject/compte_has_photos/{id} | Updates the CompteHasPhoto resource.
[**PostCompteHasPhotoCollection**](CompteHasPhotoApi.md#postcomptehasphotocollection) | **POST** /PhotoBoothProject/compte_has_photos | Creates a CompteHasPhoto resource.
[**PutCompteHasPhotoItem**](CompteHasPhotoApi.md#putcomptehasphotoitem) | **PUT** /PhotoBoothProject/compte_has_photos/{id} | Replaces the CompteHasPhoto resource.

<a name="deletecomptehasphotoitem"></a>
# **DeleteCompteHasPhotoItem**
> void DeleteCompteHasPhotoItem (string id)

Removes the CompteHasPhoto resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCompteHasPhotoItemExample
    {
        public void main()
        {
            var apiInstance = new CompteHasPhotoApi();
            var id = id_example;  // string | 

            try
            {
                // Removes the CompteHasPhoto resource.
                apiInstance.DeleteCompteHasPhotoItem(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompteHasPhotoApi.DeleteCompteHasPhotoItem: " + e.Message );
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
<a name="getcomptehasphotocollection"></a>
# **GetCompteHasPhotoCollection**
> Object GetCompteHasPhotoCollection (int? page = null)

Retrieves the collection of CompteHasPhoto resources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCompteHasPhotoCollectionExample
    {
        public void main()
        {
            var apiInstance = new CompteHasPhotoApi();
            var page = 56;  // int? | The collection page number (optional) 

            try
            {
                // Retrieves the collection of CompteHasPhoto resources.
                Object result = apiInstance.GetCompteHasPhotoCollection(page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompteHasPhotoApi.GetCompteHasPhotoCollection: " + e.Message );
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
<a name="getcomptehasphotoitem"></a>
# **GetCompteHasPhotoItem**
> ComponentsschemasCompteHasPhotojsonld GetCompteHasPhotoItem (string id)

Retrieves a CompteHasPhoto resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCompteHasPhotoItemExample
    {
        public void main()
        {
            var apiInstance = new CompteHasPhotoApi();
            var id = id_example;  // string | 

            try
            {
                // Retrieves a CompteHasPhoto resource.
                ComponentsschemasCompteHasPhotojsonld result = apiInstance.GetCompteHasPhotoItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompteHasPhotoApi.GetCompteHasPhotoItem: " + e.Message );
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

[**ComponentsschemasCompteHasPhotojsonld**](ComponentsschemasCompteHasPhotojsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="patchcomptehasphotoitem"></a>
# **PatchCompteHasPhotoItem**
> ComponentsschemasCompteHasPhotojsonld PatchCompteHasPhotoItem (string id, CompteHasPhoto body = null)

Updates the CompteHasPhoto resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchCompteHasPhotoItemExample
    {
        public void main()
        {
            var apiInstance = new CompteHasPhotoApi();
            var id = id_example;  // string | 
            var body = new CompteHasPhoto(); // CompteHasPhoto | The updated CompteHasPhoto resource (optional) 

            try
            {
                // Updates the CompteHasPhoto resource.
                ComponentsschemasCompteHasPhotojsonld result = apiInstance.PatchCompteHasPhotoItem(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompteHasPhotoApi.PatchCompteHasPhotoItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **body** | [**CompteHasPhoto**](CompteHasPhoto.md)| The updated CompteHasPhoto resource | [optional] 

### Return type

[**ComponentsschemasCompteHasPhotojsonld**](ComponentsschemasCompteHasPhotojsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/merge-patch+json
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postcomptehasphotocollection"></a>
# **PostCompteHasPhotoCollection**
> ComponentsschemasCompteHasPhotojsonld PostCompteHasPhotoCollection (CompteHasPhoto body = null)

Creates a CompteHasPhoto resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostCompteHasPhotoCollectionExample
    {
        public void main()
        {
            var apiInstance = new CompteHasPhotoApi();
            var body = new CompteHasPhoto(); // CompteHasPhoto | The new CompteHasPhoto resource (optional) 

            try
            {
                // Creates a CompteHasPhoto resource.
                ComponentsschemasCompteHasPhotojsonld result = apiInstance.PostCompteHasPhotoCollection(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompteHasPhotoApi.PostCompteHasPhotoCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompteHasPhoto**](CompteHasPhoto.md)| The new CompteHasPhoto resource | [optional] 

### Return type

[**ComponentsschemasCompteHasPhotojsonld**](ComponentsschemasCompteHasPhotojsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/ld+json, application/json, text/html
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putcomptehasphotoitem"></a>
# **PutCompteHasPhotoItem**
> ComponentsschemasCompteHasPhotojsonld PutCompteHasPhotoItem (string id, CompteHasPhoto body = null)

Replaces the CompteHasPhoto resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutCompteHasPhotoItemExample
    {
        public void main()
        {
            var apiInstance = new CompteHasPhotoApi();
            var id = id_example;  // string | 
            var body = new CompteHasPhoto(); // CompteHasPhoto | The updated CompteHasPhoto resource (optional) 

            try
            {
                // Replaces the CompteHasPhoto resource.
                ComponentsschemasCompteHasPhotojsonld result = apiInstance.PutCompteHasPhotoItem(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompteHasPhotoApi.PutCompteHasPhotoItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **body** | [**CompteHasPhoto**](CompteHasPhoto.md)| The updated CompteHasPhoto resource | [optional] 

### Return type

[**ComponentsschemasCompteHasPhotojsonld**](ComponentsschemasCompteHasPhotojsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/ld+json, application/json, text/html
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
