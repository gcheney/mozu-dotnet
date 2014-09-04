
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

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	A product type is like a product template.
		///
		public class ProductType
		{
			public string GoodsType { get; set; }

			///
			///Unique identifier of the product type.
			///
			public int? Id { get; set; }

			///
			///If true, this product is associated with the overall product type. There is only one BaseProductType per site group. System-supplied and read-only.
			///
			public bool IsBaseProductType { get; set; }

			///
			///The unique identifier of the master catalog associated with the entity.
			///
			public int? MasterCatalogId { get; set; }

			///
			///Name of the product type, such as "Shoes" or "TVs."
			///
			public string Name { get; set; }

			///
			///The number of products associated with this product type.
			///
			public int? ProductCount { get; set; }

			///
			///List of product usages that describe how products of this type are used. Products of this type can be Standard (a single product without configurable options), Configurable (a product that includes configurable option attributes), Bundle (a collection of products sold as a single entity), or Component (an invididual product that represents a component in a bundle). Product type usages cannot be both Bundle and Configurable.
			///
			public List<string> ProductUsages { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///The list of product type attributes which exist as extras. Example: monogram
			///
			public List<AttributeInProductType> Extras { get; set; }

			///
			///The list of product type attributes which exist as options.
			///
			public List<AttributeInProductType> Options { get; set; }

			///
			///The list of product type attributes which exist as properties, such as color.
			///
			public List<AttributeInProductType> Properties { get; set; }

		}

}