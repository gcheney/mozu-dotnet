
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.PaymentService
{
		///
		///	Mozu.PaymentService.Contracts.OrderItem ApiType DOCUMENT_HERE 
		///
		public class OrderItem
		{
			///
			///Unique identifier of the source product property. For a product field it will be the name of the field. For a product attribute it will be the Attribute FQN. 
			///
			public string Id { get; set; }

			///
			///The properties of a product, referenced and used by carts, orders, wish lists, and returns.
			///
			public Product Product { get; set; }

			///
			///The specified quantity of objects and items. This property is used for numerous object types including products, options, components within a product bundle, cart and order items, returned items, shipping line items, items in a digital product. and items associated with types and reservations.
			///
			public int Quantity { get; set; }

			///
			///Mozu.PaymentService.Contracts.OrderItem taxAmount ApiTypeMember DOCUMENT_HERE 
			///
			public decimal? TaxAmount { get; set; }

			///
			///Mozu.PaymentService.Contracts.OrderItem totalAmount ApiTypeMember DOCUMENT_HERE 
			///
			public decimal? TotalAmount { get; set; }

			///
			///Properties of the price per unit of a product, associated with cart and order items. This price is not used for wish lists at this time.
			///
			public decimal? UnitPrice { get; set; }

		}

}