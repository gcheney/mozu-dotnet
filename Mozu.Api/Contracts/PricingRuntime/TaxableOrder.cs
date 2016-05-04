
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


namespace Mozu.Api.Contracts.PricingRuntime
{
		///
		///	Properties of an order for which to calculate tax. When a tax capability is enabled for a tenant, Mozu sends the TaxableOrder properties to the capability as read-only, system-supplied information.
		///
		public class TaxableOrder
		{
			///
			///3-letter ISO 4217 standard global currency code. Currently, only "USD" (US Dollar) is supported.
			///
			public string CurrencyCode { get; set; }

			///
			///Handling fee associated with the order.
			///
			public decimal HandlingFee { get; set; }

			///
			///The line items associated with the order.
			///
			public List<TaxableLineItem> LineItems { get; set; }

			///
			///The date and time the order was submitted.
			///
			public DateTime OrderDate { get; set; }

			///
			///The unique identifier of the original order, used to track order changes for tax purposes.
			///
			public string OriginalDocumentCode { get; set; }

			///
			///The date and time the original order was placed.
			///
			public DateTime OriginalOrderDate { get; set; }

			///
			///The total shipping amount calculated for the order.
			///
			public decimal ShippingAmount { get; set; }

			///
			///The tax properties associated with the order.
			///
			public TaxContext TaxContext { get; set; }

			///
			///The type of request for which to tax this entity, which is "Order" or "Return."
			///
			public string TaxRequestType { get; set; }

		}

}