
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


namespace Mozu.Api.Contracts.PaymentService
{
		///
		///	Account information for the payment gateway.
		///
		public class GatewayAccount
		{
			///
			///The 2-letter geographic code representing the country for the physical or mailing address. Currently limited to the US.
			///
			public string CountryCode { get; set; }

			///
			///Identifier of the payment gateway.
			///
			public string GatewayDefinitionId { get; set; }

			///
			///Identifier of the entity.
			///
			public string Id { get; set; }

			///
			///If true, the product is marked as available for sale. Setting a product to IsActive = false will prevent it from being shown on the customer facing storefront.
			///
			public bool IsActive { get; set; }

			///
			///List of credential fields for the payment gateway account.
			///
			public List<GatewayCredentialFieldValue> CredentialFields { get; set; }

		}

}