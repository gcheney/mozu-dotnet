
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

using Mozu.Api.Contracts.CommerceRuntime.Orders;
using Mozu.Api.Contracts.CommerceRuntime.Products;

namespace Mozu.Api.Contracts.CommerceRuntime.Returns
{
		///
		///	Properties of a previously fulfilled item associated with a return.
		///
		public class ReturnItem
		{
			///
			///Properties of a collection of component products that make up a single product bundle with its own product code. Tenants can define product bundles for any product type that supports the Bundle product usage.
			///
			public List<ReturnBundle> BundledProducts { get; set; }

			///
			///Unique identifier of the source product property. For a product field it will be the name of the field. For a product attribute it will be the Attribute FQN. 
			///
			public string Id { get; set; }

			///
			///Paged list collection of note content for objects including customers, orders, and returns. 
			///
			public List<OrderNote> Notes { get; set; }

			///
			///Unique identifier of the order item associated with a validation message, order, or return.
			///
			public string OrderItemId { get; set; }

			///
			///This is the Option attribute FQN for the item being returned .. typically only when the return item is a product bundle item.
			///
			public string OrderItemOptionAttributeFQN { get; set; }

			///
			///The OrderLineId that this ReturnItem is associated with. If order item is present, the orderLineId should be present also.
			///
			public int? OrderLineId { get; set; }

			///
			///The properties of a product, referenced and used by carts, orders, wish lists, and returns.
			///
			public Product Product { get; set; }

			///
			///The total value of the product returned to the merchant for accounting purposes, calculated by multiplying the cost of the item by its quantity returned.
			///
			public decimal? ProductLossAmount { get; set; }

			///
			///The total tax amount levied on the product loss amount.
			///
			public decimal? ProductLossTaxAmount { get; set; }

			///
			///The actual quantity received for the return item.
			///
			public int QuantityReceived { get; set; }

			///
			///The quantity of returned items that can be returned to active product stock.
			///
			public int QuantityRestockable { get; set; }

			///
			///The quantity of the item shipped to the shopper in the event of a return item replacement.
			///
			public int QuantityShipped { get; set; }

			///
			///The list of return reasons for the item and the quantity associated with each return reason.
			///
			public List<ReturnReason> Reasons { get; set; }

			///
			///The total value of shipping the returned product to the merchant for accounting purposes, calculated by multiplying the shipping cost of the item by its quantity returned.
			///
			public decimal? ShippingLossAmount { get; set; }

			///
			///The total tax amount levied on the shipping loss amount.
			///
			public decimal? ShippingLossTaxAmount { get; set; }

		}

}