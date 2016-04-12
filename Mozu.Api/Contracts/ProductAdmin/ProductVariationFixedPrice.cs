
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
		///	Mozu.ProductAdmin.Contracts.ProductVariationFixedPrice ApiType DOCUMENT_HERE 
		///
		public class ProductVariationFixedPrice
		{
			///
			///The credit value of the product or bundled product. When the `goodsType `is `DigitalCredit`, this value is populated to indicate the value of the credit. This is used to create store credit in the fulfillment of gift cards.
			///
			public decimal? CreditValue { get; set; }

			///
			///The localized currency code for the monetary amount. 
			///
			public string CurrencyCode { get; set; }

			///
			///Variation price for fixed pricing
			///
			public decimal? ListPrice { get; set; }

			///
			///The manufacturer's suggested retail price for the product. This content may be defined by the supplier.
			///
			public decimal? Msrp { get; set; }

			///
			///The set sale price for a product consisting of a price with a discount already applied.
			///
			public decimal? SalePrice { get; set; }

		}

}