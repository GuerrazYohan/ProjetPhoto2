# Swagger\Client\EvenementsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteEvenementsItem**](EvenementsApi.md#deleteevenementsitem) | **DELETE** /PhotoBoothProject/evenements/{id} | Removes the Evenements resource.
[**getEvenementsCollection**](EvenementsApi.md#getevenementscollection) | **GET** /PhotoBoothProject/evenements | Retrieves the collection of Evenements resources.
[**getEvenementsItem**](EvenementsApi.md#getevenementsitem) | **GET** /PhotoBoothProject/evenements/{id} | Retrieves a Evenements resource.
[**patchEvenementsItem**](EvenementsApi.md#patchevenementsitem) | **PATCH** /PhotoBoothProject/evenements/{id} | Updates the Evenements resource.
[**postEvenementsCollection**](EvenementsApi.md#postevenementscollection) | **POST** /PhotoBoothProject/evenements | Creates a Evenements resource.
[**putEvenementsItem**](EvenementsApi.md#putevenementsitem) | **PUT** /PhotoBoothProject/evenements/{id} | Replaces the Evenements resource.

# **deleteEvenementsItem**
> deleteEvenementsItem($id)

Removes the Evenements resource.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\EvenementsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = "id_example"; // string | 

try {
    $apiInstance->deleteEvenementsItem($id);
} catch (Exception $e) {
    echo 'Exception when calling EvenementsApi->deleteEvenementsItem: ', $e->getMessage(), PHP_EOL;
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

# **getEvenementsCollection**
> object getEvenementsCollection($page)

Retrieves the collection of Evenements resources.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\EvenementsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$page = 56; // int | The collection page number

try {
    $result = $apiInstance->getEvenementsCollection($page);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EvenementsApi->getEvenementsCollection: ', $e->getMessage(), PHP_EOL;
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

# **getEvenementsItem**
> \Swagger\Client\Model\ComponentsSchemasEvenementsJsonld getEvenementsItem($id)

Retrieves a Evenements resource.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\EvenementsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = "id_example"; // string | 

try {
    $result = $apiInstance->getEvenementsItem($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EvenementsApi->getEvenementsItem: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  |

### Return type

[**\Swagger\Client\Model\ComponentsSchemasEvenementsJsonld**](../Model/ComponentsSchemasEvenementsJsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **patchEvenementsItem**
> \Swagger\Client\Model\ComponentsSchemasEvenementsJsonld patchEvenementsItem($id, $body)

Updates the Evenements resource.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\EvenementsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = "id_example"; // string | 
$body = new \Swagger\Client\Model\Evenements(); // \Swagger\Client\Model\Evenements | The updated Evenements resource

try {
    $result = $apiInstance->patchEvenementsItem($id, $body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EvenementsApi->patchEvenementsItem: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  |
 **body** | [**\Swagger\Client\Model\Evenements**](../Model/Evenements.md)| The updated Evenements resource | [optional]

### Return type

[**\Swagger\Client\Model\ComponentsSchemasEvenementsJsonld**](../Model/ComponentsSchemasEvenementsJsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/merge-patch+json
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **postEvenementsCollection**
> \Swagger\Client\Model\ComponentsSchemasEvenementsJsonld postEvenementsCollection($body)

Creates a Evenements resource.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\EvenementsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\Evenements(); // \Swagger\Client\Model\Evenements | The new Evenements resource

try {
    $result = $apiInstance->postEvenementsCollection($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EvenementsApi->postEvenementsCollection: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\Evenements**](../Model/Evenements.md)| The new Evenements resource | [optional]

### Return type

[**\Swagger\Client\Model\ComponentsSchemasEvenementsJsonld**](../Model/ComponentsSchemasEvenementsJsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/ld+json, application/json, text/html
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **putEvenementsItem**
> \Swagger\Client\Model\ComponentsSchemasEvenementsJsonld putEvenementsItem($id, $body)

Replaces the Evenements resource.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\EvenementsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = "id_example"; // string | 
$body = new \Swagger\Client\Model\Evenements(); // \Swagger\Client\Model\Evenements | The updated Evenements resource

try {
    $result = $apiInstance->putEvenementsItem($id, $body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EvenementsApi->putEvenementsItem: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  |
 **body** | [**\Swagger\Client\Model\Evenements**](../Model/Evenements.md)| The updated Evenements resource | [optional]

### Return type

[**\Swagger\Client\Model\ComponentsSchemasEvenementsJsonld**](../Model/ComponentsSchemasEvenementsJsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/ld+json, application/json, text/html
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

