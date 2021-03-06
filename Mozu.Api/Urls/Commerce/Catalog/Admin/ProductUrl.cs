
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Commerce.Catalog.Admin
{
	public partial class ProductUrl 
	{

		/// <summary>
        /// Get Resource Url for GetProducts
        /// </summary>
        /// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
        /// <param name="noCount">If true, the operation does not return the TotalCount number of results.</param>
        /// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
        /// <param name="q">A list of order search terms (not phrases) to use in the query when searching across order number and the name or email of the billing contact. When entering, separate multiple search terms with a space character.</param>
        /// <param name="qLimit">The maximum number of search results to return in the response. You can limit any range between 1-100.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetProductsUrl(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string q =  null, int? qLimit =  null, bool? noCount =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/products/?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}&q={q}&qLimit={qLimit}&noCount={noCount}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "noCount", noCount);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "q", q);
			mozuUrl.FormatUrl( "qLimit", qLimit);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetProductInCatalogs
        /// </summary>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetProductInCatalogsUrl(string productCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/ProductInCatalogs";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "productCode", productCode);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetProductInCatalog
        /// </summary>
        /// <param name="catalogId">The unique identifier of the catalog of products used by a site.</param>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetProductInCatalogUrl(string productCode, int catalogId, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/ProductInCatalogs/{catalogId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "catalogId", catalogId);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetProduct
        /// </summary>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetProductUrl(string productCode, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddProduct
        /// </summary>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddProductUrl(string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/products/?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for AddProductInCatalog
        /// </summary>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddProductInCatalogUrl(string productCode, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/ProductInCatalogs?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for RenameProductCodes
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl RenameProductCodesUrl()
		{
			var url = "/api/commerce/catalog/admin/products/Actions/RenameProductCodes";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateProductInCatalogs
        /// </summary>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateProductInCatalogsUrl(string productCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/ProductInCatalogs";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "productCode", productCode);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for UpdateProductInCatalog
        /// </summary>
        /// <param name="catalogId">The unique identifier of the catalog of products used by a site.</param>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateProductInCatalogUrl(string productCode, int catalogId, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/ProductInCatalogs/{catalogId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "catalogId", catalogId);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for UpdateProduct
        /// </summary>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateProductUrl(string productCode, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteProduct
        /// </summary>
        /// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteProductUrl(string productCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "productCode", productCode);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for DeleteProductInCatalog
        /// </summary>
        /// <param name="catalogId">The unique identifier of the catalog of products used by a site.</param>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteProductInCatalogUrl(string productCode, int catalogId)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/ProductInCatalogs/{catalogId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "catalogId", catalogId);
			mozuUrl.FormatUrl( "productCode", productCode);
			return mozuUrl;
		}

		
	}
}

