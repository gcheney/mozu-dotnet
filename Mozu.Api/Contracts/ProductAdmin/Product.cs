
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
		///	The properties of a product, referenced and used by carts, orders, wish lists, and returns.
		///
		public class Product
		{
			///
			///List of discounts available per configured conditions and criteria. These discounts are associated with products, orders, and shipping costs. Shoppers can view these discounts per order, per product in an order, or for their shipping depending on the configuration.
			///
			public List<Discount> ApplicableDiscounts { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///Product code defined by the tenant administrator to use as a base prefix when generating product codes for any variations of this product.
			///
			public string BaseProductCode { get; set; }

			///
			///Properties of a collection of component products that make up a single product bundle with its own product code. Tenants can define product bundles for any product type that supports the Bundle product usage.
			///
			public List<BundledProduct> BundledProducts { get; set; }

			public ProductLocalizedContent Content { get; set; }

			///
			///List of extra product attributes defined for this product. For example, monogram could be a possible extra for a shirt product.
			///
			public List<ProductExtra> Extras { get; set; }

			///
			///List of supported types of fulfillment for the product or variation. The types include direct ship, in-store pickup, or both.
			///
			public List<string> FulfillmentTypesSupported { get; set; }

			///
			///If true, the product has configurable options. This option means that a product is not purchasable until the shopper selects options that resolve into a product variation. Configurable options for a product are the choices a shopper makes when ordering a product. Size and color are configurable options. System-supplied and read-only.
			///
			public bool HasConfigurableOptions { get; set; }

			///
			///If true, this product has standalone options that a shopper can select without configuring a defined product variations. System-supplied and read only.
			///
			public bool HasStandAloneOptions { get; set; }

			///
			///Properties and data of inventory information for configured and bundled products. If product stock is managed, the data specifies out of stock behavior.
			///
			public ProductInventoryInfo InventoryInfo { get; set; }

			///
			///Indicates if the product must be shipped alone in a container. This is used for products and products within a bundle. If true, this product cannot be shipped in a package with other items and must ship in a package by itself.
			///
			public bool? IsPackagedStandAlone { get; set; }

			///
			///Indicates if the product in a cart, order, or wish list is purchased on a recurring schedule. If true, the item can be purchased or fulfilled at regular intervals, such as a monthly billing cycle. For example, digital or physical product subscriptions are recurring cart items. This property is not used at this time and is reserved for future functionality.
			///
			public bool? IsRecurring { get; set; }

			///
			///Indicates if the item is subject to taxation, used by products, options, extras, cart and order items, line items, and wish lists. If true, the entity is subject to tax based on the relevant tax rate and rules.
			///
			public bool? IsTaxable { get; set; }

			///
			///If true, this product is valid for the assigned product type.
			///
			public bool? IsValidForProductType { get; set; }

			///
			///If true, this configured product represents a product variation defined with configurable options. System-supplied and read only.
			///
			public bool IsVariation { get; set; }

			///
			///The unique identifier of the master catalog associated with the entity.
			///
			public int? MasterCatalogId { get; set; }

			///
			///List of option attributes configured for an object. These values are associated and used by products, product bundles, and product types.
			///
			public List<ProductOption> Options { get; set; }

			///
			///Height of a package or bundle package in imperial units of feet and inches.
			///
			public Measurement PackageHeight { get; set; }

			///
			///Length of a package or bundle package in imperial units of feet and inches.
			///
			public Measurement PackageLength { get; set; }

			///
			///Weight of a package or bundle package in imperial units of pounds and ounces.
			///
			public Measurement PackageWeight { get; set; }

			///
			///Width of a package or bundle package in imperial units of feet and inches.
			///
			public Measurement PackageWidth { get; set; }

			///
			///Unit price that the client intends to sell the product if no sale price is set.
			///
			public ProductPrice Price { get; set; }

			///
			///Properties that describe the behavior the system uses when determining the price of products.
			///
			public ProductPricingBehaviorInfo PricingBehavior { get; set; }

			///
			///Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.
			///
			public string ProductCode { get; set; }

			///
			///Properties defined for a product as they appear in its associated catalogs.
			///
			public List<ProductInCatalogInfo> ProductInCatalogs { get; set; }

			///
			///Integer that represents the sequential order of the product.
			///
			public int? ProductSequence { get; set; }

			///
			///Unique identifier of the product type assigned for this product. Tenant administrators can only define one product type per product.
			///
			public int? ProductTypeId { get; set; }

			///
			///The usage type that applies to this product, which is Standard (a single product without configurable options), Configurable (a product that includes configurable option attributes), Bundle (a collection of products sold as a single entity), or Component (an invididual product that represents a component in a bundle).
			///
			public string ProductUsage { get; set; }

			///
			///Collection of property attributes defined for the object. Properties are associated to all objects within , including documents, products, and product types.
			///
			public List<ProductProperty> Properties { get; set; }

			///
			///Properties of the product publishing settings for the associated product.
			///
			public ProductPublishingInfo PublishingInfo { get; set; }

			///
			///The search engine optimized content defined for products or products associated with a catalog. If no SEO content is specified in the request for products associated with a catalog, this catalog uses the SEO content defined in the master catalog. To override the SEO content for this catalog, the `IsSEOContentOverridden `flag must be set to "true".
			///
			public ProductLocalizedSEOContent SeoContent { get; set; }

			///
			///Identifier of the shipping class.
			///
			public int? ShippingClassId { get; set; }

			///
			///If the product must be packaged separately, the type of standalone package to use.
			///
			public string StandAlonePackageType { get; set; }

			///
			///Supplier-defined properties assigned for the product.
			///
			public ProductSupplierInfo SupplierInfo { get; set; }

			///
			///The universal product code (UPC) is the barcode defined for the product. The UPC is unique across all sales channels. 
			///
			public string Upc { get; set; }

			///
			///System-generated key that represents the attribute values that uniquely identify a specific product variation.
			///
			public string VariationKey { get; set; }

			///
			///The list of product variation configurations defined for this product based on its available product option attributes.
			///
			public List<ProductVariationOption> VariationOptions { get; set; }

		}

}