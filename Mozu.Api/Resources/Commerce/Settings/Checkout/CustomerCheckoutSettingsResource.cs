
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

namespace Mozu.Api.Resources.Commerce.Settings.Checkout
{
	/// <summary>
	/// Use the Customer Checkout Settings resource to define login settings that apply when shoppers proceed to checkout.
	/// </summary>
	public partial class CustomerCheckoutSettingsResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public CustomerCheckoutSettingsResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public CustomerCheckoutSettingsResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new CustomerCheckoutSettingsResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves all checkout settings defined for the site: Payment settings, such as the payment gateway ID and credentials, supported credit cards, and more; Customer Checkout settings, such as whether login is required, and any custom attributes; and Order Processing settings, such as when payment is authorized and captured, and any custom attributes.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Order.CustomerCheckoutSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customercheckoutsettings = new CustomerCheckoutSettings();
		///   var customerCheckoutSettings = customercheckoutsettings.GetCustomerCheckoutSettings( responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.SiteSettings.Order.CustomerCheckoutSettings GetCustomerCheckoutSettings(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.Order.CustomerCheckoutSettings> response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.CustomerCheckoutSettingsClient.GetCustomerCheckoutSettingsClient( responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves all checkout settings defined for the site: Payment settings, such as the payment gateway ID and credentials, supported credit cards, and more; Customer Checkout settings, such as whether login is required, and any custom attributes; and Order Processing settings, such as when payment is authorized and captured, and any custom attributes.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Order.CustomerCheckoutSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customercheckoutsettings = new CustomerCheckoutSettings();
		///   var customerCheckoutSettings = await customercheckoutsettings.GetCustomerCheckoutSettingsAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.SiteSettings.Order.CustomerCheckoutSettings> GetCustomerCheckoutSettingsAsync(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.Order.CustomerCheckoutSettings> response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.CustomerCheckoutSettingsClient.GetCustomerCheckoutSettingsClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Modifies existing site checkout settings. Modify Payment, Customer Checkout, and Order Processing settings in one PUT.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="customerCheckoutSettings">The properties of the customer checkout settings such as whether shoppers must be logged in.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Order.CustomerCheckoutSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customercheckoutsettings = new CustomerCheckoutSettings();
		///   var customerCheckoutSettings = customercheckoutsettings.UpdateCustomerCheckoutSettings( customerCheckoutSettings,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.SiteSettings.Order.CustomerCheckoutSettings UpdateCustomerCheckoutSettings(Mozu.Api.Contracts.SiteSettings.Order.CustomerCheckoutSettings customerCheckoutSettings, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.Order.CustomerCheckoutSettings> response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.CustomerCheckoutSettingsClient.UpdateCustomerCheckoutSettingsClient( customerCheckoutSettings,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Modifies existing site checkout settings. Modify Payment, Customer Checkout, and Order Processing settings in one PUT.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="customerCheckoutSettings">The properties of the customer checkout settings such as whether shoppers must be logged in.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Order.CustomerCheckoutSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customercheckoutsettings = new CustomerCheckoutSettings();
		///   var customerCheckoutSettings = await customercheckoutsettings.UpdateCustomerCheckoutSettingsAsync( customerCheckoutSettings,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.SiteSettings.Order.CustomerCheckoutSettings> UpdateCustomerCheckoutSettingsAsync(Mozu.Api.Contracts.SiteSettings.Order.CustomerCheckoutSettings customerCheckoutSettings, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.Order.CustomerCheckoutSettings> response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.CustomerCheckoutSettingsClient.UpdateCustomerCheckoutSettingsClient( customerCheckoutSettings,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


