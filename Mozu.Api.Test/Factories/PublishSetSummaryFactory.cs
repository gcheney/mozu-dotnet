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
	/// 
	/// </summary>
	public partial class PublishSetSummaryFactory : BaseDataFactory
	{

		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		/// var result = PublishSetSummaryFactory.GetPublishSets(handler : handler,  pageSize :  pageSize,  startIndex :  startIndex,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<PublishSetSummaryPagedCollection/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.Content.PublishSetSummaryPagedCollection GetPublishSets(ServiceClientMessageHandler handler, 
 		 int? pageSize = null, int? startIndex = null, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Content.PublishSetSummaryClient.GetPublishSetsClient(
				 pageSize :  pageSize,  startIndex :  startIndex,  responseFields :  responseFields		);
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
		/// var result = PublishSetSummaryFactory.GetPublishSetItems(handler : handler,  code :  code,  pageSize :  pageSize,  startIndex :  startIndex,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<DocumentDraftSummaryPagedCollection/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.Content.DocumentDraftSummaryPagedCollection GetPublishSetItems(ServiceClientMessageHandler handler, 
 		 string code, int? pageSize = null, int? startIndex = null, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Content.PublishSetSummaryClient.GetPublishSetItemsClient(
				 code :  code,  pageSize :  pageSize,  startIndex :  startIndex,  responseFields :  responseFields		);
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
		/// var result = PublishSetSummaryFactory.DeletePublishSet(handler : handler,  code :  code,  shouldDiscard :  shouldDiscard,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<object/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static object DeletePublishSet(ServiceClientMessageHandler handler, 
 		 string code, bool? shouldDiscard = null, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Content.PublishSetSummaryClient.DeletePublishSetClient(
				 code :  code,  shouldDiscard :  shouldDiscard,  responseFields :  responseFields		);
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
		/// var result = PublishSetSummaryFactory.AddPublishSetItems(handler : handler,  documentIds :  documentIds,  code :  code,  responseFields :  responseFields,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<object/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static object AddPublishSetItems(ServiceClientMessageHandler handler, 
 		 List<string> documentIds, string code, string responseFields = null, 
		 HttpStatusCode expectedCode = HttpStatusCode.Created, HttpStatusCode successCode = HttpStatusCode.Created)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Content.PublishSetSummaryClient.AddPublishSetItemsClient(
				 documentIds :  documentIds,  code :  code,  responseFields :  responseFields		);
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

