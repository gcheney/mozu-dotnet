
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
using Mozu.Api.Security;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Mozu.Api.Clients.Commerce.Catalog.Admin.Products
{
	/// <summary>
	/// Use the product variations sub-resource to manage the variations of a product based on its attributes. For example, a t-shirt product could be offered in six variations: Small Black, Medium Black, Large Black, Small White, Medium White, and Large White.
	/// </summary>
	public partial class ProductVariationClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="productCode"></param>
		/// <param name="variationKey"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProductVariationLocalizedDeltaPrices(dataViewMode,  productCode,  variationKey);
		///   var productVariationDeltaPriceClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice>> GetProductVariationLocalizedDeltaPricesClient(DataViewMode dataViewMode, string productCode, string variationKey)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductVariationUrl.GetProductVariationLocalizedDeltaPricesUrl(productCode, variationKey);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="currencyCode"></param>
		/// <param name="productCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="variationKey"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProductVariationLocalizedDeltaPrice(dataViewMode,  productCode,  variationKey,  currencyCode,  responseFields);
		///   var productVariationDeltaPriceClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice> GetProductVariationLocalizedDeltaPriceClient(DataViewMode dataViewMode, string productCode, string variationKey, string currencyCode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductVariationUrl.GetProductVariationLocalizedDeltaPriceUrl(productCode, variationKey, currencyCode, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of a product variation based on the supplied product code and variation key.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields"></param>
		/// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProductVariation(dataViewMode,  productCode,  variationKey,  responseFields);
		///   var productVariationClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariation> GetProductVariationClient(DataViewMode dataViewMode, string productCode, string variationKey, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductVariationUrl.GetProductVariationUrl(productCode, variationKey, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariation>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves a list of the product variations configured for the specified product code.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationPagedCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProductVariations(dataViewMode,  productCode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		///   var productVariationPagedCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationPagedCollection> GetProductVariationsClient(DataViewMode dataViewMode, string productCode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductVariationUrl.GetProductVariationsUrl(productCode, startIndex, pageSize, sortBy, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationPagedCollection>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="productCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="variationKey"></param>
		/// <param name="localizedDeltaPrice"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddProductVariationLocalizedDeltaPrice(dataViewMode,  localizedDeltaPrice,  productCode,  variationKey,  responseFields);
		///   var productVariationDeltaPriceClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice> AddProductVariationLocalizedDeltaPriceClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice localizedDeltaPrice, string productCode, string variationKey, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductVariationUrl.AddProductVariationLocalizedDeltaPriceUrl(productCode, variationKey, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice>(localizedDeltaPrice)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="productCode"></param>
		/// <param name="variationKey"></param>
		/// <param name="localizedDeltaPrice"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateProductVariationLocalizedDeltaPrices(dataViewMode,  localizedDeltaPrice,  productCode,  variationKey);
		///   var productVariationDeltaPriceClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice>> UpdateProductVariationLocalizedDeltaPricesClient(DataViewMode dataViewMode, List<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice> localizedDeltaPrice, string productCode, string variationKey)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductVariationUrl.UpdateProductVariationLocalizedDeltaPricesUrl(productCode, variationKey);
			const string verb = "PUT";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice>>(localizedDeltaPrice)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="currencyCode"></param>
		/// <param name="productCode"></param>
		/// <param name="responseFields"></param>
		/// <param name="variationKey"></param>
		/// <param name="localizedDeltaPrice"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateProductVariationLocalizedDeltaPrice(dataViewMode,  localizedDeltaPrice,  productCode,  variationKey,  currencyCode,  responseFields);
		///   var productVariationDeltaPriceClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice> UpdateProductVariationLocalizedDeltaPriceClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice localizedDeltaPrice, string productCode, string variationKey, string currencyCode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductVariationUrl.UpdateProductVariationLocalizedDeltaPriceUrl(productCode, variationKey, currencyCode, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.ProductVariationDeltaPrice>(localizedDeltaPrice)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Modifies the details of a variation, based on the supplied variation key, for the specified product code.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields"></param>
		/// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
		/// <param name="productVariation">Wrapper for the properties of the specified product variation.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateProductVariation(dataViewMode,  productVariation,  productCode,  variationKey,  responseFields);
		///   var productVariationClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariation> UpdateProductVariationClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductVariation productVariation, string productCode, string variationKey, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductVariationUrl.UpdateProductVariationUrl(productCode, variationKey, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariation>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.ProductVariation>(productVariation)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Modifies the collection of variations for the specified product code. Because this PUT replaces the existing resource, supply all information necessary to maintain for the product variation.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields"></param>
		/// <param name="productVariations">Wrapper for the collection of variations configured for the specified product code.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateProductVariations(dataViewMode,  productVariations,  productCode,  responseFields);
		///   var productVariationCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationCollection> UpdateProductVariationsClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductVariationCollection productVariations, string productCode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductVariationUrl.UpdateProductVariationsUrl(productCode, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationCollection>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.ProductVariationCollection>(productVariations)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Deletes a variation, based on the supplied variation key, for the specified product code.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteProductVariation(dataViewMode,  productCode,  variationKey);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteProductVariationClient(DataViewMode dataViewMode, string productCode, string variationKey)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductVariationUrl.DeleteProductVariationUrl(productCode, variationKey);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="currencyCode"></param>
		/// <param name="productCode"></param>
		/// <param name="variationKey"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteProductVariationLocalizedDeltaPrice(dataViewMode,  productCode,  variationKey,  currencyCode);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteProductVariationLocalizedDeltaPriceClient(DataViewMode dataViewMode, string productCode, string variationKey, string currencyCode)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Products.ProductVariationUrl.DeleteProductVariationLocalizedDeltaPriceUrl(productCode, variationKey, currencyCode);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}


	}

}


