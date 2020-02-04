# Swagger\Client\CompteHasPhotoApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteCompteHasPhotoItem**](CompteHasPhotoApi.md#deletecomptehasphotoitem) | **DELETE** /PhotoBoothProject/compte_has_photos/{id} | Removes the CompteHasPhoto resource.
[**getCompteHasPhotoCollection**](CompteHasPhotoApi.md#getcomptehasphotocollection) | **GET** /PhotoBoothProject/compte_has_photos | Retrieves the collection of CompteHasPhoto resources.
[**getCompteHasPhotoItem**](CompteHasPhotoApi.md#getcomptehasphotoitem) | **GET** /PhotoBoothProject/compte_has_photos/{id} | Retrieves a CompteHasPhoto resource.
[**patchCompteHasPhotoItem**](CompteHasPhotoApi.md#patchcomptehasphotoitem) | **PATCH** /PhotoBoothProject/compte_has_photos/{id} | Updates the CompteHasPhoto resource.
[**postCompteHasPhotoCollection**](CompteHasPhotoApi.md#postcomptehasphotocollection) | **POST** /PhotoBoothProject/compte_has_photos | Creates a CompteHasPhoto resource.
[**putCompteHasPhotoItem**](CompteHasPhotoApi.md#putcomptehasphotoitem) | **PUT** /PhotoBoothProject/compte_has_photos/{id} | Replaces the CompteHasPhoto resource.

# **deleteCompteHasPhotoItem**
> deleteCompteHasPhotoItem($id)

Removes the CompteHasPhoto resource.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CompteHasPhotoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = "id_example"; // string | 

try {
    $apiInstance->deleteCompteHasPhotoItem($id);
} catch (Exception $e) {
    echo 'Exception when calling CompteHasPhotoApi->deleteCompteHasPhotoItem: ', $e->getMessage(), PHP_EOL;
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

# **getCompteHasPhotoCollection**
> object getCompteHasPhotoCollection($page)

Retrieves the collection of CompteHasPhoto resources.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CompteHasPhotoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$page = 56; // int | The collection page number

try {
    $result = $apiInstance->getCompteHasPhotoCollection($page);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CompteHasPhotoApi->getCompteHasPhotoCollection: ', $e->getMessage(), PHP_EOL;
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

# **getCompteHasPhotoItem**
> \Swagger\Client\Model\ComponentsSchemasCompteHasPhotoJsonld getCompteHasPhotoItem($id)

Retrieves a CompteHasPhoto resource.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CompteHasPhotoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = "id_example"; // string | 

try {
    $result = $apiInstance->getCompteHasPhotoItem($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CompteHasPhotoApi->getCompteHasPhotoItem: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  |

### Return type

[**\Swagger\Client\Model\ComponentsSchemasCompteHasPhotoJsonld**](../Model/ComponentsSchemasCompteHasPhotoJsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **patchCompteHasPhotoItem**
> \Swagger\Client\Model\ComponentsSchemasCompteHasPhotoJsonld patchCompteHasPhotoItem($id, $body)

Updates the CompteHasPhoto resource.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CompteHasPhotoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = "id_example"; // string | 
$body = new \Swagger\Client\Model\CompteHasPhoto(); // \Swagger\Client\Model\CompteHasPhoto | The updated CompteHasPhoto resource

try {
    $result = $apiInstance->patchCompteHasPhotoItem($id, $body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CompteHasPhotoApi->patchCompteHasPhotoItem: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  |
 **body** | [**\Swagger\Client\Model\CompteHasPhoto**](../Model/CompteHasPhoto.md)| The updated CompteHasPhoto resource | [optional]

### Return type

[**\Swagger\Client\Model\ComponentsSchemasCompteHasPhotoJsonld**](../Model/ComponentsSchemasCompteHasPhotoJsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/merge-patch+json
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **postCompteHasPhotoCollection**
> \Swagger\Client\Model\ComponentsSchemasCompteHasPhotoJsonld postCompteHasPhotoCollection($body)

Creates a CompteHasPhoto resource.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CompteHasPhotoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\CompteHasPhoto(); // \Swagger\Client\Model\CompteHasPhoto | The new CompteHasPhoto resource

try {
    $result = $apiInstance->postCompteHasPhotoCollection($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CompteHasPhotoApi->postCompteHasPhotoCollection: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\CompteHasPhoto**](../Model/CompteHasPhoto.md)| The new CompteHasPhoto resource | [optional]

### Return type

[**\Swagger\Client\Model\ComponentsSchemasCompteHasPhotoJsonld**](../Model/ComponentsSchemasCompteHasPhotoJsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/ld+json, application/json, text/html
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **putCompteHasPhotoItem**
> \Swagger\Client\Model\ComponentsSchemasCompteHasPhotoJsonld putCompteHasPhotoItem($id, $body)

Replaces the CompteHasPhoto resource.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CompteHasPhotoApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = "id_example"; // string | 
$body = new \Swagger\Client\Model\CompteHasPhoto(); // \Swagger\Client\Model\CompteHasPhoto | The updated CompteHasPhoto resource

try {
    $result = $apiInstance->putCompteHasPhotoItem($id, $body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CompteHasPhotoApi->putCompteHasPhotoItem: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  |
 **body** | [**\Swagger\Client\Model\CompteHasPhoto**](../Model/CompteHasPhoto.md)| The updated CompteHasPhoto resource | [optional]

### Return type

[**\Swagger\Client\Model\ComponentsSchemasCompteHasPhotoJsonld**](../Model/ComponentsSchemasCompteHasPhotoJsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/ld+json, application/json, text/html
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

