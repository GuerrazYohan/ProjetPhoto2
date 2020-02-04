# Swagger\Client\PhotoApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deletePhotoItem**](PhotoApi.md#deletephotoitem) | **DELETE** /PhotoBoothProject/photos/{id} | Removes the Photo resource.
[**getPhotoCollection**](PhotoApi.md#getphotocollection) | **GET** /PhotoBoothProject/photos | Retrieves the collection of Photo resources.
[**getPhotoItem**](PhotoApi.md#getphotoitem) | **GET** /PhotoBoothProject/photos/{id} | Retrieves a Photo resource.
[**patchPhotoItem**](PhotoApi.md#patchphotoitem) | **PATCH** /PhotoBoothProject/photos/{id} | Updates the Photo resource.
[**postPhotoCollection**](PhotoApi.md#postphotocollection) | **POST** /PhotoBoothProject/photos | Creates a Photo resource.
[**putPhotoItem**](PhotoApi.md#putphotoitem) | **PUT** /PhotoBoothProject/photos/{id} | Replaces the Photo resource.

# **deletePhotoItem**
> deletePhotoItem($id)

Removes the Photo resource.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\PhotoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = "id_example"; // string | 

try {
    $apiInstance->deletePhotoItem($id);
} catch (Exception $e) {
    echo 'Exception when calling PhotoApi->deletePhotoItem: ', $e->getMessage(), PHP_EOL;
}
?>
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **getPhotoCollection**
> object getPhotoCollection($page)

Retrieves the collection of Photo resources.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\PhotoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$page = 56; // int | The collection page number

try {
    $result = $apiInstance->getPhotoCollection($page);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PhotoApi->getPhotoCollection: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int**| The collection page number | [optional]

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **getPhotoItem**
> \Swagger\Client\Model\ComponentsSchemasPhotoJsonld getPhotoItem($id)

Retrieves a Photo resource.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\PhotoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = "id_example"; // string | 

try {
    $result = $apiInstance->getPhotoItem($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PhotoApi->getPhotoItem: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  |

### Return type

[**\Swagger\Client\Model\ComponentsSchemasPhotoJsonld**](../Model/ComponentsSchemasPhotoJsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **patchPhotoItem**
> \Swagger\Client\Model\ComponentsSchemasPhotoJsonld patchPhotoItem($id, $body)

Updates the Photo resource.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\PhotoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = "id_example"; // string | 
$body = new \Swagger\Client\Model\Photo(); // \Swagger\Client\Model\Photo | The updated Photo resource

try {
    $result = $apiInstance->patchPhotoItem($id, $body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PhotoApi->patchPhotoItem: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  |
 **body** | [**\Swagger\Client\Model\Photo**](../Model/Photo.md)| The updated Photo resource | [optional]

### Return type

[**\Swagger\Client\Model\ComponentsSchemasPhotoJsonld**](../Model/ComponentsSchemasPhotoJsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/merge-patch+json
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **postPhotoCollection**
> \Swagger\Client\Model\ComponentsSchemasPhotoJsonld postPhotoCollection($body)

Creates a Photo resource.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\PhotoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\Photo(); // \Swagger\Client\Model\Photo | The new Photo resource

try {
    $result = $apiInstance->postPhotoCollection($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PhotoApi->postPhotoCollection: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\Photo**](../Model/Photo.md)| The new Photo resource | [optional]

### Return type

[**\Swagger\Client\Model\ComponentsSchemasPhotoJsonld**](../Model/ComponentsSchemasPhotoJsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/ld+json, application/json, text/html
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **putPhotoItem**
> \Swagger\Client\Model\ComponentsSchemasPhotoJsonld putPhotoItem($id, $body)

Replaces the Photo resource.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\PhotoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = "id_example"; // string | 
$body = new \Swagger\Client\Model\Photo(); // \Swagger\Client\Model\Photo | The updated Photo resource

try {
    $result = $apiInstance->putPhotoItem($id, $body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling PhotoApi->putPhotoItem: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  |
 **body** | [**\Swagger\Client\Model\Photo**](../Model/Photo.md)| The updated Photo resource | [optional]

### Return type

[**\Swagger\Client\Model\ComponentsSchemasPhotoJsonld**](../Model/ComponentsSchemasPhotoJsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/ld+json, application/json, text/html
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

