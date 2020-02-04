# Swagger\Client\CompteApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteCompteItem**](CompteApi.md#deletecompteitem) | **DELETE** /PhotoBoothProject/comptes/{id} | Removes the Compte resource.
[**getCompteCollection**](CompteApi.md#getcomptecollection) | **GET** /PhotoBoothProject/comptes | Retrieves the collection of Compte resources.
[**getCompteItem**](CompteApi.md#getcompteitem) | **GET** /PhotoBoothProject/comptes/{id} | Retrieves a Compte resource.
[**patchCompteItem**](CompteApi.md#patchcompteitem) | **PATCH** /PhotoBoothProject/comptes/{id} | Updates the Compte resource.
[**postCompteCollection**](CompteApi.md#postcomptecollection) | **POST** /PhotoBoothProject/comptes | Creates a Compte resource.
[**putCompteItem**](CompteApi.md#putcompteitem) | **PUT** /PhotoBoothProject/comptes/{id} | Replaces the Compte resource.

# **deleteCompteItem**
> deleteCompteItem($id)

Removes the Compte resource.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CompteApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = "id_example"; // string | 

try {
    $apiInstance->deleteCompteItem($id);
} catch (Exception $e) {
    echo 'Exception when calling CompteApi->deleteCompteItem: ', $e->getMessage(), PHP_EOL;
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

# **getCompteCollection**
> object getCompteCollection($page)

Retrieves the collection of Compte resources.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CompteApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$page = 56; // int | The collection page number

try {
    $result = $apiInstance->getCompteCollection($page);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CompteApi->getCompteCollection: ', $e->getMessage(), PHP_EOL;
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

# **getCompteItem**
> \Swagger\Client\Model\ComponentsSchemasCompteJsonld getCompteItem($id)

Retrieves a Compte resource.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CompteApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = "id_example"; // string | 

try {
    $result = $apiInstance->getCompteItem($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CompteApi->getCompteItem: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  |

### Return type

[**\Swagger\Client\Model\ComponentsSchemasCompteJsonld**](../Model/ComponentsSchemasCompteJsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **patchCompteItem**
> \Swagger\Client\Model\ComponentsSchemasCompteJsonld patchCompteItem($id, $body)

Updates the Compte resource.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CompteApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = "id_example"; // string | 
$body = new \Swagger\Client\Model\Compte(); // \Swagger\Client\Model\Compte | The updated Compte resource

try {
    $result = $apiInstance->patchCompteItem($id, $body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CompteApi->patchCompteItem: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  |
 **body** | [**\Swagger\Client\Model\Compte**](../Model/Compte.md)| The updated Compte resource | [optional]

### Return type

[**\Swagger\Client\Model\ComponentsSchemasCompteJsonld**](../Model/ComponentsSchemasCompteJsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/merge-patch+json
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **postCompteCollection**
> \Swagger\Client\Model\ComponentsSchemasCompteJsonld postCompteCollection($body)

Creates a Compte resource.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CompteApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\Compte(); // \Swagger\Client\Model\Compte | The new Compte resource

try {
    $result = $apiInstance->postCompteCollection($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CompteApi->postCompteCollection: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\Compte**](../Model/Compte.md)| The new Compte resource | [optional]

### Return type

[**\Swagger\Client\Model\ComponentsSchemasCompteJsonld**](../Model/ComponentsSchemasCompteJsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/ld+json, application/json, text/html
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **putCompteItem**
> \Swagger\Client\Model\ComponentsSchemasCompteJsonld putCompteItem($id, $body)

Replaces the Compte resource.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CompteApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = "id_example"; // string | 
$body = new \Swagger\Client\Model\Compte(); // \Swagger\Client\Model\Compte | The updated Compte resource

try {
    $result = $apiInstance->putCompteItem($id, $body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CompteApi->putCompteItem: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  |
 **body** | [**\Swagger\Client\Model\Compte**](../Model/Compte.md)| The updated Compte resource | [optional]

### Return type

[**\Swagger\Client\Model\ComponentsSchemasCompteJsonld**](../Model/ComponentsSchemasCompteJsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/ld+json, application/json, text/html
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

