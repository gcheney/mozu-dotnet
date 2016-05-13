
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Mozu.Api.Security;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Mozu.Api.Resources.Commerce.Orders
{
	/// <summary>
	/// Use the Billing Info subresource to manage the billing information stored for an order.
	/// </summary>
	public partial class BillingInfoResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public BillingInfoResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public BillingInfoResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new BillingInfoResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves the billing information associated with an order.
		/// </summary>
		/// <param name="draft">If true, retrieve the draft version of the order billing information, which might include uncommitted changes.</param>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var billinginfo = new BillingInfo();
		///   var billingInfo = billinginfo.GetBillingInfo( orderId,  draft,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo GetBillingInfo(string orderId, bool? draft =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo> response;
			var client = Mozu.Api.Clients.Commerce.Orders.BillingInfoClient.GetBillingInfoClient( orderId,  draft,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the billing information associated with an order.
		/// </summary>
		/// <param name="draft">If true, retrieve the draft version of the order billing information, which might include uncommitted changes.</param>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var billinginfo = new BillingInfo();
		///   var billingInfo = await billinginfo.GetBillingInfoAsync( orderId,  draft,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo> GetBillingInfoAsync(string orderId, bool? draft =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo> response;
			var client = Mozu.Api.Clients.Commerce.Orders.BillingInfoClient.GetBillingInfoClient( orderId,  draft,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates the billing information supplied for an order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="updateMode">Specifies whether to set the billing information by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal," "ApplyToDraft," or "ApplyAndCommit."</param>
		/// <param name="version">System-supplied integer that represents the current version of the order, which prevents users from unintentionally overriding changes to the order. When a user performs an operation for a defined order, the system validates that the version of the updated order matches the version of the order on the server. After the operation completes successfully, the system increments the version number by one.</param>
		/// <param name="billingInfo">The properties of the order billing information to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var billinginfo = new BillingInfo();
		///   var billingInfo = billinginfo.SetBillingInfo( billingInfo,  orderId,  updateMode,  version,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo SetBillingInfo(Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo billingInfo, string orderId, string updateMode =  null, string version =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo> response;
			var client = Mozu.Api.Clients.Commerce.Orders.BillingInfoClient.SetBillingInfoClient( billingInfo,  orderId,  updateMode,  version,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates the billing information supplied for an order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="updateMode">Specifies whether to set the billing information by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal," "ApplyToDraft," or "ApplyAndCommit."</param>
		/// <param name="version">System-supplied integer that represents the current version of the order, which prevents users from unintentionally overriding changes to the order. When a user performs an operation for a defined order, the system validates that the version of the updated order matches the version of the order on the server. After the operation completes successfully, the system increments the version number by one.</param>
		/// <param name="billingInfo">The properties of the order billing information to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var billinginfo = new BillingInfo();
		///   var billingInfo = await billinginfo.SetBillingInfoAsync( billingInfo,  orderId,  updateMode,  version,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo> SetBillingInfoAsync(Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo billingInfo, string orderId, string updateMode =  null, string version =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo> response;
			var client = Mozu.Api.Clients.Commerce.Orders.BillingInfoClient.SetBillingInfoClient( billingInfo,  orderId,  updateMode,  version,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


