# Swagger\Client\EvenementsAttenteApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deleteEvenementsAttenteItem**](EvenementsAttenteApi.md#deleteevenementsattenteitem) | **DELETE** /PhotoBoothProject/evenements_attentes/{id} | Removes the EvenementsAttente resource.
[**getEvenementsAttenteCollection**](EvenementsAttenteApi.md#getevenementsattentecollection) | **GET** /PhotoBoothProject/evenements_attentes | Retrieves the collection of EvenementsAttente resources.
[**getEvenementsAttenteItem**](EvenementsAttenteApi.md#getevenementsattenteitem) | **GET** /PhotoBoothProject/evenements_attentes/{id} | Retrieves a EvenementsAttente resource.
[**patchEvenementsAttenteItem**](EvenementsAttenteApi.md#patchevenementsattenteitem) | **PATCH** /PhotoBoothProject/evenements_attentes/{id} | Updates the EvenementsAttente resource.
[**postEvenementsAttenteCollection**](EvenementsAttenteApi.md#postevenementsattentecollection) | **POST** /PhotoBoothProject/evenements_attentes | Creates a EvenementsAttente resource.
[**putEvenementsAttenteItem**](EvenementsAttenteApi.md#putevenementsattenteitem) | **PUT** /PhotoBoothProject/evenements_attentes/{id} | Replaces the EvenementsAttente resource.

# **deleteEvenementsAttenteItem**
> deleteEvenementsAttenteItem($id)

Removes the EvenementsAttente resource.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\EvenementsAttenteApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = "id_example"; // string | 

try {
    $apiInstance->deleteEvenementsAttenteItem($id);
} catch (Exception $e) {
    echo 'Exception when calling EvenementsAttenteApi->deleteEvenementsAttenteItem: ', $e->getMessage(), PHP_EOL;
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

# **getEvenementsAttenteCollection**
> object getEvenementsAttenteCollection($page)

Retrieves the collection of EvenementsAttente resources.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\EvenementsAttenteApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$page = 56; // int | The collection page number

try {
    $result = $apiInstance->getEvenementsAttenteCollection($page);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EvenementsAttenteApi->getEvenementsAttenteCollection: ', $e->getMessage(), PHP_EOL;
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

# **getEvenementsAttenteItem**
> \Swagger\Client\Model\ComponentsSchemasEvenementsAttenteJsonld getEvenementsAttenteItem($id)

Retrieves a EvenementsAttente resource.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\EvenementsAttenteApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = "id_example"; // string | 

try {
    $result = $apiInstance->getEvenementsAttenteItem($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EvenementsAttenteApi->getEvenementsAttenteItem: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  |

### Return type

[**\Swagger\Client\Model\ComponentsSchemasEvenementsAttenteJsonld**](../Model/ComponentsSchemasEvenementsAttenteJsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **patchEvenementsAttenteItem**
> \Swagger\Client\Model\ComponentsSchemasEvenementsAttenteJsonld patchEvenementsAttenteItem($id, $body)

Updates the EvenementsAttente resource.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\EvenementsAttenteApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = "id_example"; // string | 
$body = new \Swagger\Client\Model\EvenementsAttente(); // \Swagger\Client\Model\EvenementsAttente | The updated EvenementsAttente resource

try {
    $result = $apiInstance->patchEvenementsAttenteItem($id, $body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EvenementsAttenteApi->patchEvenementsAttenteItem: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  |
 **body** | [**\Swagger\Client\Model\EvenementsAttente**](../Model/EvenementsAttente.md)| The updated EvenementsAttente resource | [optional]

### Return type

[**\Swagger\Client\Model\ComponentsSchemasEvenementsAttenteJsonld**](../Model/ComponentsSchemasEvenementsAttenteJsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/merge-patch+json
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **postEvenementsAttenteCollection**
> \Swagger\Client\Model\ComponentsSchemasEvenementsAttenteJsonld postEvenementsAttenteCollection($body)

Creates a EvenementsAttente resource.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\EvenementsAttenteApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\EvenementsAttente(); // \Swagger\Client\Model\EvenementsAttente | The new EvenementsAttente resource

try {
    $result = $apiInstance->postEvenementsAttenteCollection($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EvenementsAttenteApi->postEvenementsAttenteCollection: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\EvenementsAttente**](../Model/EvenementsAttente.md)| The new EvenementsAttente resource | [optional]

### Return type

[**\Swagger\Client\Model\ComponentsSchemasEvenementsAttenteJsonld**](../Model/ComponentsSchemasEvenementsAttenteJsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/ld+json, application/json, text/html
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **putEvenementsAttenteItem**
> \Swagger\Client\Model\ComponentsSchemasEvenementsAttenteJsonld putEvenementsAttenteItem($id, $body)

Replaces the EvenementsAttente resource.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\EvenementsAttenteApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = "id_example"; // string | 
$body = new \Swagger\Client\Model\EvenementsAttente(); // \Swagger\Client\Model\EvenementsAttente | The updated EvenementsAttente resource

try {
    $result = $apiInstance->putEvenementsAttenteItem($id, $body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EvenementsAttenteApi->putEvenementsAttenteItem: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  |
 **body** | [**\Swagger\Client\Model\EvenementsAttente**](../Model/EvenementsAttente.md)| The updated EvenementsAttente resource | [optional]

### Return type

[**\Swagger\Client\Model\ComponentsSchemasEvenementsAttenteJsonld**](../Model/ComponentsSchemasEvenementsAttenteJsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/ld+json, application/json, text/html
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

