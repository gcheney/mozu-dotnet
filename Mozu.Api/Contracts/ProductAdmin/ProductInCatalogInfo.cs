
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
		///	Properties of a product associated with a specific catalog.
		///
		public class ProductInCatalogInfo
		{
			///
			///If true, the product is marked as available for sale in the catalog. Setting a product to IsActive = false will prevent it from being shown on the customer facing storefront.
			///
			public ActiveDateRange ActiveDateRange { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///The unique identifier of the catalog of products used by a site.
			///
			public int CatalogId { get; set; }

			///
			///Localizable content (such as a name and/or description) for an attribute. The content may be localized when displayed according to the locale code specified by the master catalog. Content can include descriptive text for product extensible attributes, catalog-level descriptions (displayed if isContentOverriden is true), product bundles, and customer account notes.
			///
			public ProductLocalizedContent Content { get; set; }

			///
			///Date this product was first Available for sale in the catalog. This is utilized in expressions that refrence DaysInCatloag.
			///
			public DateTime? DateFirstAvailableInCatalog { get; set; }

			///
			///Indicates if the object or feature is active.
			///
			public bool? IsActive { get; set; }

			///
			///If true, the content defined for this product in the master catalog in overridden in the catalog with the content specified in the request body. If false, this catalog uses the content defined in the master catalog for the product.
			///
			public bool? IsContentOverridden { get; set; }

			///
			///If true, the price defined for this product in the master catalog in overridden in the catalog with the price specified in the request body. If false, this catalog uses the price defined in the master catalog for the product.
			///
			public bool? IsPriceOverridden { get; set; }

			///
			///If true, the SEO content defined for this product in the master catalog in overridden in the catalog with the SEO content specified in the request body. If false, this catalog uses the SEO content defined in the master catalog for the product.
			///
			public bool? IsseoContentOverridden { get; set; }

			///
			///The price of the product associated with the specified catalog. If no price is specified in the request, this catalog uses the price defined in the master catalog. To override the product price for this catalog, the IsPriceOverridden flag must be set to "true".
			///
			public ProductPrice Price { get; set; }

			///
			///Specifies which static category to use in the navigation breadcrumb, regardless of how shoppers navigate to the product. If not set, or if the product belongs only to dynamic categories, the default is to use the category with the smallest ID.
			///
			public ProductCategory PrimaryProductCategory { get; set; }

			///
			///The product categories to define for the product associated with the specified catalog.
			///
			public List<ProductCategory> ProductCategories { get; set; }

			///
			///The search engine optimized content defined for products or products associated with a catalog. If no SEO content is specified in the request for products associated with a catalog, this catalog uses the SEO content defined in the master catalog. To override the SEO content for this catalog, the `IsSEOContentOverridden `flag must be set to "true".
			///
			public ProductLocalizedSEOContent SeoContent { get; set; }

		}

}