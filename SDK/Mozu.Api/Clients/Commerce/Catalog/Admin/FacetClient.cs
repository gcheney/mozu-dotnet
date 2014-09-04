
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

namespace Mozu.Api.Clients.Commerce.Catalog.Admin
{
	/// <summary>
	/// Use the Facets resource to manage the facets shoppers use to filter product display results on a storefront. Facets can include categories, product attributes, or prices, and use either a range of values or discrete values.
	/// </summary>
	public partial class FacetClient 	{
		
		/// <summary>
		/// Retrieves a facet specified by its unique identifier and displays its properties.
		/// </summary>
		/// <param name="facetId">Unique identifier of the facet to retrieve.</param>
		/// <param name="responseFields"></param>
		/// <param name="validate">Validates that the product category associated with a facet is active. System-supplied and read only.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Facet"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetFacet( facetId,  validate,  responseFields);
		///   var facetClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Facet> GetFacetClient(int facetId, bool? validate =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.FacetUrl.GetFacetUrl(facetId, validate, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Facet>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves a list of the facets defined for the specified category.
		/// </summary>
		/// <param name="categoryId">Unique identifier of the category associated with the facets to retrieve.</param>
		/// <param name="includeAvailable">If true, returns a list of the attributes and categories associated with a product type that have not been defined as a facet for the category.</param>
		/// <param name="responseFields"></param>
		/// <param name="validate">Validates that the product category associated with a facet is active. System-supplied and read only.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.FacetSet"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetFacetCategoryList( categoryId,  includeAvailable,  validate,  responseFields);
		///   var facetSetClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.FacetSet> GetFacetCategoryListClient(int categoryId, bool? includeAvailable =  null, bool? validate =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.FacetUrl.GetFacetCategoryListUrl(categoryId, includeAvailable, validate, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.FacetSet>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Creates a new category, price, or attribute facet. Define the category or attribute source to use for the facet values.
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="facet">Properties of the new facet to create. You must specify the source, type, and category.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Facet"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddFacet( facet,  responseFields);
		///   var facetClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Facet> AddFacetClient(Mozu.Api.Contracts.ProductAdmin.Facet facet, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.FacetUrl.AddFacetUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Facet>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.Facet>(facet);
			return mozuClient;

		}

		/// <summary>
		/// Modifies one or more properties of a defined facet.
		/// </summary>
		/// <param name="facetId">Unique identifier of the facet to modify.</param>
		/// <param name="responseFields"></param>
		/// <param name="facet">Properties of the defined facet to modify.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Facet"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateFacet( facet,  facetId,  responseFields);
		///   var facetClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Facet> UpdateFacetClient(Mozu.Api.Contracts.ProductAdmin.Facet facet, int facetId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.FacetUrl.UpdateFacetUrl(facetId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Facet>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.Facet>(facet);
			return mozuClient;

		}

		/// <summary>
		/// Deletes the facet specified by its unique identifier.
		/// </summary>
		/// <param name="facetId">Unique identifier of the facet to delete.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteFacetById( facetId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteFacetByIdClient(int facetId)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.FacetUrl.DeleteFacetByIdUrl(facetId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


