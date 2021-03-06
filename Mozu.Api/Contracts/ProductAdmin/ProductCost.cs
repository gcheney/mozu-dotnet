
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	The cost a client pays the supplier to stock the product.
		///
		public class ProductCost
		{
			///
			///The amount paid by the client to stock the product.
			///
			public decimal? Cost { get; set; }

			///
			///3-letter ISO 4217 standard global currency code. Currently, only "USD" (US Dollar) is supported.
			///
			public string IsoCurrencyCode { get; set; }

		}

}