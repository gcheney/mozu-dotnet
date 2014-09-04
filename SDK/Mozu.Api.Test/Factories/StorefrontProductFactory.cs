//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#region Usings Setup

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using Mozu.Api;
using Mozu.Api.Security;
using Mozu.Api.Test.Helpers;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

#endregion

namespace Mozu.Api.Test.Factories
{
	/// <summary>
	/// Use the Storefront Products  resource to manage the shopper product selection process during a visit to the web storefront. You can update product options as shoppers pick and choose their product choices. A shopper cannot add a product to a cart until all of its required options have been selected.
	/// </summary>
	public partial class StorefrontProductFactory : BaseDataFactory
	{

		/// <summary> 
		/// Retrieves a list of products that appear on the storefront according to any specified filter criteria and sort options.
		/// <example> 
		///  <code> 
		/// var result = ProductFactory.GetProducts(handler : handler,  filter :  filter,  startIndex :  startIndex,  pageSize :  pageSize,  sortBy :  sortBy,  responseFields :  responseFields,  dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<ProductCollection/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductRuntime.ProductCollection GetProducts(ServiceClientMessageHandler handler, 
 		 string filter = null, int? startIndex = null, int? pageSize = null, string sortBy = null, string responseFields = null,  DataViewMode dataViewMode= DataViewMode.Live, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductClient.GetProductsClient(
				 filter :  filter,  startIndex :  startIndex,  pageSize :  pageSize,  sortBy :  sortBy,  responseFields :  responseFields, dataViewMode: dataViewMode		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// Retrieves the active inventory level information associated with the product or location specified in the request.
		/// <example> 
		///  <code> 
		/// var result = ProductFactory.GetProductInventory(handler : handler,  productCode :  productCode,  locationCodes :  locationCodes,  responseFields :  responseFields,  dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<LocationInventoryCollection/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductRuntime.LocationInventoryCollection GetProductInventory(ServiceClientMessageHandler handler, 
 		 string productCode, string locationCodes = null, string responseFields = null,  DataViewMode dataViewMode= DataViewMode.Live, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductClient.GetProductInventoryClient(
				 productCode :  productCode,  locationCodes :  locationCodes,  responseFields :  responseFields, dataViewMode: dataViewMode		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// Retrieves information about a single product given its product code.
		/// <example> 
		///  <code> 
		/// var result = ProductFactory.GetProduct(handler : handler,  productCode :  productCode,  variationProductCode :  variationProductCode,  allowInactive :  allowInactive,  skipInventoryCheck :  skipInventoryCheck,  responseFields :  responseFields,  dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<Product/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductRuntime.Product GetProduct(ServiceClientMessageHandler handler, 
 		 string productCode, string variationProductCode = null, bool? allowInactive = null, bool? skipInventoryCheck = null, string responseFields = null,  DataViewMode dataViewMode= DataViewMode.Live, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductClient.GetProductClient(
				 productCode :  productCode,  variationProductCode :  variationProductCode,  allowInactive :  allowInactive,  skipInventoryCheck :  skipInventoryCheck,  responseFields :  responseFields, dataViewMode: dataViewMode		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// Creates a new product configuration each time a shopper selects a product option value. After the shopper defines values for all required product options, the shopper can add the product configuration to a cart.
		/// <example> 
		///  <code> 
		/// var result = ProductFactory.ConfiguredProduct(handler : handler,  productOptionSelections :  productOptionSelections,  productCode :  productCode,  includeOptionDetails :  includeOptionDetails,  skipInventoryCheck :  skipInventoryCheck,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<ConfiguredProduct/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductRuntime.ConfiguredProduct ConfiguredProduct(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.ProductRuntime.ProductOptionSelections productOptionSelections, string productCode, bool? includeOptionDetails = null, bool? skipInventoryCheck = null, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductClient.ConfiguredProductClient(
				 productOptionSelections :  productOptionSelections,  productCode :  productCode,  includeOptionDetails :  includeOptionDetails,  skipInventoryCheck :  skipInventoryCheck,  responseFields :  responseFields		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// Validate the final state of shopper-selected options.
		/// <example> 
		///  <code> 
		/// var result = ProductFactory.ValidateProduct(handler : handler,  productOptionSelections :  productOptionSelections,  productCode :  productCode,  skipInventoryCheck :  skipInventoryCheck,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<ProductValidationSummary/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductRuntime.ProductValidationSummary ValidateProduct(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.ProductRuntime.ProductOptionSelections productOptionSelections, string productCode, bool? skipInventoryCheck = null, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductClient.ValidateProductClient(
				 productOptionSelections :  productOptionSelections,  productCode :  productCode,  skipInventoryCheck :  skipInventoryCheck,  responseFields :  responseFields		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		/// var result = ProductFactory.ValidateDiscounts(handler : handler,  discountSelections :  discountSelections,  productCode :  productCode,  variationProductCode :  variationProductCode,  customerAccountId :  customerAccountId,  allowInactive :  allowInactive,  skipInventoryCheck :  skipInventoryCheck,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<DiscountValidationSummary/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductRuntime.DiscountValidationSummary ValidateDiscounts(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.ProductRuntime.DiscountSelections discountSelections, string productCode, string variationProductCode = null, int? customerAccountId = null, bool? allowInactive = null, bool? skipInventoryCheck = null, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductClient.ValidateDiscountsClient(
				 discountSelections :  discountSelections,  productCode :  productCode,  variationProductCode :  variationProductCode,  customerAccountId :  customerAccountId,  allowInactive :  allowInactive,  skipInventoryCheck :  skipInventoryCheck,  responseFields :  responseFields		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		/// var result = ProductFactory.GetProductInventories(handler : handler,  query :  query,  responseFields :  responseFields,  dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<LocationInventoryCollection/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductRuntime.LocationInventoryCollection GetProductInventories(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.ProductRuntime.LocationInventoryQuery query, string responseFields = null,  DataViewMode dataViewMode= DataViewMode.Live, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Storefront.ProductClient.GetProductInventoriesClient(
				 query :  query,  responseFields :  responseFields, dataViewMode: dataViewMode		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  

	}

}


