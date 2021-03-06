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
	/// Retrieves the details of a price list. The details may contain a hierarchy of ancestor and/or descendant price lists dependening on your configuration.
	/// </summary>
	public partial class StorefrontPriceListFactory : BaseDataFactory
	{

		/// <summary> 
		/// Retrieves the details of the specified price list.
		/// <example> 
		///  <code> 
		/// var result = PriceListFactory.GetPriceList(handler : handler,  priceListCode :  priceListCode,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<PriceList/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductRuntime.PriceList GetPriceList(ServiceClientMessageHandler handler, 
 		 string priceListCode, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Storefront.PriceListClient.GetPriceListClient(
				 priceListCode :  priceListCode,  responseFields :  responseFields		);
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
		/// Retrieves the details of a price list to which the specified customer resolves. This is primarly used when creating an offline order for a shopper.You can use this operation alongside custom Arc.js actions to alter the price list to which a shopper resolves.
		/// <example> 
		///  <code> 
		/// var result = PriceListFactory.GetResolvedPriceList(handler : handler,  customerAccountId :  customerAccountId,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<ResolvedPriceList/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductRuntime.ResolvedPriceList GetResolvedPriceList(ServiceClientMessageHandler handler, 
 		 int? customerAccountId = null, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Storefront.PriceListClient.GetResolvedPriceListClient(
				 customerAccountId :  customerAccountId,  responseFields :  responseFields		);
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


