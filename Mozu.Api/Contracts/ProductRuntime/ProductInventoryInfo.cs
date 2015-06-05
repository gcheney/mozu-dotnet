
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.ProductRuntime
{
		///
		///	Properties of the inventory behavior associated with a product definition.
		///
		public class ProductInventoryInfo
		{
			///
			///Indicates is the item's stock is managed. If true, Mozu manages inventory levels for this product.
			///
			public bool? ManageStock { get; set; }

			///
			///The location code for the direct ship location associated with the available online stock.
			///
			public string OnlineLocationCode { get; set; }

			///
			///Number of product items currently available for purchase.
			///
			public int? OnlineSoftStockAvailable { get; set; }

			///
			///The current number of products that are available for purchase.
			///
			public int? OnlineStockAvailable { get; set; }

			///
			///Determines the method this product uses when active stock is depeleted. Options include "DisplayMessage" to display an out of stock message to the shopper, "HideProduct" to disable the product on the storefront, or "AllowBackOrder" to allow the shopper to back order the product. This property is required only if Mozu manages inventory for this product.
			///
			public string OutOfStockBehavior { get; set; }

		}

}