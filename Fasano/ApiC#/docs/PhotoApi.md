# IO.Swagger.Api.PhotoApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletePhotoItem**](PhotoApi.md#deletephotoitem) | **DELETE** /PhotoBoothProject/photos/{id} | Removes the Photo resource.
[**GetPhotoCollection**](PhotoApi.md#getphotocollection) | **GET** /PhotoBoothProject/photos | Retrieves the collection of Photo resources.
[**GetPhotoItem**](PhotoApi.md#getphotoitem) | **GET** /PhotoBoothProject/photos/{id} | Retrieves a Photo resource.
[**PatchPhotoItem**](PhotoApi.md#patchphotoitem) | **PATCH** /PhotoBoothProject/photos/{id} | Updates the Photo resource.
[**PostPhotoCollection**](PhotoApi.md#postphotocollection) | **POST** /PhotoBoothProject/photos | Creates a Photo resource.
[**PutPhotoItem**](PhotoApi.md#putphotoitem) | **PUT** /PhotoBoothProject/photos/{id} | Replaces the Photo resource.

<a name="deletephotoitem"></a>
# **DeletePhotoItem**
> void DeletePhotoItem (string id)

Removes the Photo resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeletePhotoItemExample
    {
        public void main()
        {
            var apiInstance = new PhotoApi();
            var id = id_example;  // string | 

            try
            {
                // Removes the Photo resource.
                apiInstance.DeletePhotoItem(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PhotoApi.DeletePhotoItem: " + e.Message );
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
<a name="getphotocollection"></a>
# **GetPhotoCollection**
> Object GetPhotoCollection (int? page = null)

Retrieves the collection of Photo resources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPhotoCollectionExample
    {
        public void main()
        {
            var apiInstance = new PhotoApi();
            var page = 56;  // int? | The collection page number (optional) 

            try
            {
                // Retrieves the collection of Photo resources.
                Object result = apiInstance.GetPhotoCollection(page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PhotoApi.GetPhotoCollection: " + e.Message );
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
<a name="getphotoitem"></a>
# **GetPhotoItem**
> ComponentsschemasPhotojsonld GetPhotoItem (string id)

Retrieves a Photo resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPhotoItemExample
    {
        public void main()
        {
            var apiInstance = new PhotoApi();
            var id = id_example;  // string | 

            try
            {
                // Retrieves a Photo resource.
                ComponentsschemasPhotojsonld result = apiInstance.GetPhotoItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PhotoApi.GetPhotoItem: " + e.Message );
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

[**ComponentsschemasPhotojsonld**](ComponentsschemasPhotojsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="patchphotoitem"></a>
# **PatchPhotoItem**
> ComponentsschemasPhotojsonld PatchPhotoItem (string id, Photo body = null)

Updates the Photo resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchPhotoItemExample
    {
        public void main()
        {
            var apiInstance = new PhotoApi();
            var id = id_example;  // string | 
            var body = new Photo(); // Photo | The updated Photo resource (optional) 

            try
            {
                // Updates the Photo resource.
                ComponentsschemasPhotojsonld result = apiInstance.PatchPhotoItem(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PhotoApi.PatchPhotoItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **body** | [**Photo**](Photo.md)| The updated Photo resource | [optional] 

### Return type

[**ComponentsschemasPhotojsonld**](ComponentsschemasPhotojsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/merge-patch+json
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postphotocollection"></a>
# **PostPhotoCollection**
> ComponentsschemasPhotojsonld PostPhotoCollection (Photo body = null)

Creates a Photo resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostPhotoCollectionExample
    {
        public void main()
        {
            var apiInstance = new PhotoApi();
            var body = new Photo(); // Photo | The new Photo resource (optional) 

            try
            {
                // Creates a Photo resource.
                ComponentsschemasPhotojsonld result = apiInstance.PostPhotoCollection(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PhotoApi.PostPhotoCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Photo**](Photo.md)| The new Photo resource | [optional] 

### Return type

[**ComponentsschemasPhotojsonld**](ComponentsschemasPhotojsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/ld+json, application/json, text/html
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="putphotoitem"></a>
# **PutPhotoItem**
> ComponentsschemasPhotojsonld PutPhotoItem (string id, Photo body = null)

Replaces the Photo resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutPhotoItemExample
    {
        public void main()
        {
            var apiInstance = new PhotoApi();
            var id = id_example;  // string | 
            var body = new Photo(); // Photo | The updated Photo resource (optional) 

            try
            {
                // Replaces the Photo resource.
                ComponentsschemasPhotojsonld result = apiInstance.PutPhotoItem(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PhotoApi.PutPhotoItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **body** | [**Photo**](Photo.md)| The updated Photo resource | [optional] 

### Return type

[**ComponentsschemasPhotojsonld**](ComponentsschemasPhotojsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/ld+json, application/json, text/html
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
