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
	/// Use the Custom Routes resource to manage your custom route settings. Custom routing allows you to display SEO-friendly URLs on your site that map behind-the-scenes to conventional  resources such as a product page or a search results page. With custom routing, you gain advanced control over the URL structures on your site and can more visibly highlight the products or categories your shoppers are interested in purchasing.To learn more about custom routing, refer to the [Custom Route Settings](../../../guides/settings/custom-routes.htm) topic.
	/// </summary>
	public partial class CustomRouteSettingsFactory : BaseDataFactory
	{

		/// <summary> 
		/// Retrieves the custom route settings configured for a site. These are the same settings configured through  in the Custom Routing JSON Editor.
		/// <example> 
		///  <code> 
		/// var result = CustomRouteSettingsFactory.GetCustomRouteSettings(handler : handler,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<CustomRouteSettings/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings GetCustomRouteSettings(ServiceClientMessageHandler handler, 
 		 string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Settings.General.CustomRouteSettingsClient.GetCustomRouteSettingsClient(
				 responseFields :  responseFields		);
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
		/// Create new custom route settings.
		/// <example> 
		///  <code> 
		/// var result = CustomRouteSettingsFactory.CreateCustomRouteSettings(handler : handler,  settings :  settings,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<CustomRouteSettings/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings CreateCustomRouteSettings(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings settings, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.Created, HttpStatusCode successCode = HttpStatusCode.Created)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Settings.General.CustomRouteSettingsClient.CreateCustomRouteSettingsClient(
				 settings :  settings,  responseFields :  responseFields		);
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
		/// Updates custom route settings.
		/// <example> 
		///  <code> 
		/// var result = CustomRouteSettingsFactory.UpdateCustomRouteSettings(handler : handler,  settings :  settings,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<CustomRouteSettings/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings UpdateCustomRouteSettings(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings settings, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Settings.General.CustomRouteSettingsClient.UpdateCustomRouteSettingsClient(
				 settings :  settings,  responseFields :  responseFields		);
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
		/// Deletes all the custom route settings for a site, returning all routes to their  defaults.
		/// <example> 
		///  <code> 
		/// var result = CustomRouteSettingsFactory.DeleteCustomRouteSettings(handler : handler,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<void/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static void DeleteCustomRouteSettings(ServiceClientMessageHandler handler, 
 		
		 HttpStatusCode expectedCode = HttpStatusCode.NoContent, HttpStatusCode successCode = HttpStatusCode.NoContent)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Settings.General.CustomRouteSettingsClient.DeleteCustomRouteSettingsClient(
						);
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
			}
			var noResponse = ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  

	}

}


