
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

namespace Mozu.Api.Resources.Commerce.Catalog.Admin
{
	/// <summary>
	/// Use the Product Administration resource to create new product definitions in the master catalog and determine which catalogs will feature products. You can also assign attribute values for defined products, manage product-level location inventory, and configure the variations of a product.
	/// </summary>
	public partial class ProductResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		private readonly DataViewMode _dataViewMode;
		
		public ProductResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
			_dataViewMode = DataViewMode.Live;
		}

		public ProductResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new ProductResource(_apiContext.CloneWith(contextModification), _dataViewMode);
		}

		public ProductResource(IApiContext apiContext, DataViewMode dataViewMode) 
		{
			_apiContext = apiContext;
			_dataViewMode = dataViewMode;
		}
				
		/// <summary>
		/// Retrieves a list of products according to any specified facets, filter criteria, and sort options.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="noCount">If true, the operation does not return the TotalCount number of results.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="q">A list of product search terms to use in the query when searching across product code and product name. Separate multiple search terms with a space character.</param>
		/// <param name="qLimit">The maximum number of search results to return in the response. You can limit any range between 1-100.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var productCollection = product.GetProducts(_dataViewMode,  startIndex,  pageSize,  sortBy,  filter,  q,  qLimit,  noCount,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductCollection GetProducts(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string q =  null, int? qLimit =  null, bool? noCount =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.GetProductsClient(_dataViewMode,  startIndex,  pageSize,  sortBy,  filter,  q,  qLimit,  noCount,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a list of products according to any specified facets, filter criteria, and sort options.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="noCount">If true, the operation does not return the TotalCount number of results.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="q">A list of product search terms to use in the query when searching across product code and product name. Separate multiple search terms with a space character.</param>
		/// <param name="qLimit">The maximum number of search results to return in the response. You can limit any range between 1-100.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var productCollection = await product.GetProductsAsync(_dataViewMode,  startIndex,  pageSize,  sortBy,  filter,  q,  qLimit,  noCount,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductCollection> GetProductsAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string q =  null, int? qLimit =  null, bool? noCount =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.GetProductsClient(_dataViewMode,  startIndex,  pageSize,  sortBy,  filter,  q,  qLimit,  noCount,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves a product that is associated with one or more specific catalogs.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var productInCatalogInfo = product.GetProductInCatalogs(_dataViewMode,  productCode);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo> GetProductInCatalogs(string productCode)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.GetProductInCatalogsClient(_dataViewMode,  productCode);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a product that is associated with one or more specific catalogs.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var productInCatalogInfo = await product.GetProductInCatalogsAsync(_dataViewMode,  productCode);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo>> GetProductInCatalogsAsync(string productCode)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.GetProductInCatalogsClient(_dataViewMode,  productCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of a product associated with a specific catalog.
		/// </summary>
		/// <param name="catalogId">The unique identifier of the catalog of products used by a site.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var productInCatalogInfo = product.GetProductInCatalog(_dataViewMode,  productCode,  catalogId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo GetProductInCatalog(string productCode, int catalogId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.GetProductInCatalogClient(_dataViewMode,  productCode,  catalogId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the details of a product associated with a specific catalog.
		/// </summary>
		/// <param name="catalogId">The unique identifier of the catalog of products used by a site.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var productInCatalogInfo = await product.GetProductInCatalogAsync(_dataViewMode,  productCode,  catalogId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo> GetProductInCatalogAsync(string productCode, int catalogId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.GetProductInCatalogClient(_dataViewMode,  productCode,  catalogId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of a product definition.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Product"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var product = product.GetProduct(_dataViewMode,  productCode,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.Product GetProduct(string productCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Product> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.GetProductClient(_dataViewMode,  productCode,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the details of a product definition.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Product"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var product = await product.GetProductAsync(_dataViewMode,  productCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Product> GetProductAsync(string productCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Product> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.GetProductClient(_dataViewMode,  productCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Creates a new product definition in the specified master catalog.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="product">Properties of the new product. You must supply values for the product code, product name, and price.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Product"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var product = product.AddProduct(_dataViewMode,  product,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.Product AddProduct(Mozu.Api.Contracts.ProductAdmin.Product product, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Product> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.AddProductClient(_dataViewMode,  product,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Creates a new product definition in the specified master catalog.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="product">Properties of the new product. You must supply values for the product code, product name, and price.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Product"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var product = await product.AddProductAsync(_dataViewMode,  product,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Product> AddProductAsync(Mozu.Api.Contracts.ProductAdmin.Product product, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Product> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.AddProductClient(_dataViewMode,  product,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Associates a new product defined in the master catalog with a specific catalog.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="productInCatalogInfoIn">Properties of the product to define for the specific catalog association.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var productInCatalogInfo = product.AddProductInCatalog(_dataViewMode,  productInCatalogInfoIn,  productCode,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo AddProductInCatalog(Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo productInCatalogInfoIn, string productCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.AddProductInCatalogClient(_dataViewMode,  productInCatalogInfoIn,  productCode,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Associates a new product defined in the master catalog with a specific catalog.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="productInCatalogInfoIn">Properties of the product to define for the specific catalog association.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var productInCatalogInfo = await product.AddProductInCatalogAsync(_dataViewMode,  productInCatalogInfoIn,  productCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo> AddProductInCatalogAsync(Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo productInCatalogInfoIn, string productCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.AddProductInCatalogClient(_dataViewMode,  productInCatalogInfoIn,  productCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="productCodeRenames"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   product.RenameProductCodes( productCodeRenames);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void RenameProductCodes(List<Mozu.Api.Contracts.ProductAdmin.ProductCodeRename> productCodeRenames)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.RenameProductCodesClient( productCodeRenames);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="productCodeRenames"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   await product.RenameProductCodesAsync( productCodeRenames);
		/// </code>
		/// </example>
		public virtual async Task RenameProductCodesAsync(List<Mozu.Api.Contracts.ProductAdmin.ProductCodeRename> productCodeRenames)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.RenameProductCodesClient( productCodeRenames);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// Updates the properties of a product specific to each catalog associated with the product.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="productInCatalogsIn">Properties of the product to update for each associated catalog.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var productInCatalogInfo = product.UpdateProductInCatalogs(_dataViewMode,  productInCatalogsIn,  productCode);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo> UpdateProductInCatalogs(List<Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo> productInCatalogsIn, string productCode)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.UpdateProductInCatalogsClient(_dataViewMode,  productInCatalogsIn,  productCode);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates the properties of a product specific to each catalog associated with the product.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="productInCatalogsIn">Properties of the product to update for each associated catalog.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var productInCatalogInfo = await product.UpdateProductInCatalogsAsync(_dataViewMode,  productInCatalogsIn,  productCode);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo>> UpdateProductInCatalogsAsync(List<Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo> productInCatalogsIn, string productCode)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.UpdateProductInCatalogsClient(_dataViewMode,  productInCatalogsIn,  productCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates one or more properties of a product associated with a specific catalog.
		/// </summary>
		/// <param name="catalogId">The unique identifier of the catalog of products used by a site.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="productInCatalogInfoIn">Properties of the product associated with the catalog specified in the request.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var productInCatalogInfo = product.UpdateProductInCatalog(_dataViewMode,  productInCatalogInfoIn,  productCode,  catalogId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo UpdateProductInCatalog(Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo productInCatalogInfoIn, string productCode, int catalogId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.UpdateProductInCatalogClient(_dataViewMode,  productInCatalogInfoIn,  productCode,  catalogId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates one or more properties of a product associated with a specific catalog.
		/// </summary>
		/// <param name="catalogId">The unique identifier of the catalog of products used by a site.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="productInCatalogInfoIn">Properties of the product associated with the catalog specified in the request.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var productInCatalogInfo = await product.UpdateProductInCatalogAsync(_dataViewMode,  productInCatalogInfoIn,  productCode,  catalogId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo> UpdateProductInCatalogAsync(Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo productInCatalogInfoIn, string productCode, int catalogId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductInCatalogInfo> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.UpdateProductInCatalogClient(_dataViewMode,  productInCatalogInfoIn,  productCode,  catalogId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates one or more properties of a product definition in a master catalog.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="product">Properties of the product definition to update in the master catalog.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Product"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var product = product.UpdateProduct(_dataViewMode,  product,  productCode,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.Product UpdateProduct(Mozu.Api.Contracts.ProductAdmin.Product product, string productCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Product> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.UpdateProductClient(_dataViewMode,  product,  productCode,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates one or more properties of a product definition in a master catalog.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="product">Properties of the product definition to update in the master catalog.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Product"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var product = await product.UpdateProductAsync(_dataViewMode,  product,  productCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Product> UpdateProductAsync(Mozu.Api.Contracts.ProductAdmin.Product product, string productCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Product> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.UpdateProductClient(_dataViewMode,  product,  productCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes the specified product from a master catalog.
		/// </summary>
		/// <param name="productCode"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   product.DeleteProduct(_dataViewMode,  productCode);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteProduct(string productCode)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.DeleteProductClient(_dataViewMode,  productCode);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Deletes the specified product from a master catalog.
		/// </summary>
		/// <param name="productCode"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   await product.DeleteProductAsync(_dataViewMode,  productCode);
		/// </code>
		/// </example>
		public virtual async Task DeleteProductAsync(string productCode)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.DeleteProductClient(_dataViewMode,  productCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// Removes the product association defined for a specific catalog.
		/// </summary>
		/// <param name="catalogId">The unique identifier of the catalog of products used by a site.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   product.DeleteProductInCatalog(_dataViewMode,  productCode,  catalogId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteProductInCatalog(string productCode, int catalogId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.DeleteProductInCatalogClient(_dataViewMode,  productCode,  catalogId);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Removes the product association defined for a specific catalog.
		/// </summary>
		/// <param name="catalogId">The unique identifier of the catalog of products used by a site.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   await product.DeleteProductInCatalogAsync(_dataViewMode,  productCode,  catalogId);
		/// </code>
		/// </example>
		public virtual async Task DeleteProductInCatalogAsync(string productCode, int catalogId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.DeleteProductInCatalogClient(_dataViewMode,  productCode,  catalogId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


