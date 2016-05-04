
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

namespace Mozu.Api.Resources.Commerce.Catalog.Admin.Attributedefinition.Producttypes
{
	/// <summary>
	/// Use the Extras subresource to define how a product attribute classified as an "extra" is used for a specific product type. Product attribute defintions are unique for each associated product type.
	/// </summary>
	public partial class ProductTypeExtraResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		private readonly DataViewMode _dataViewMode;
		
		public ProductTypeExtraResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
			_dataViewMode = DataViewMode.Live;
		}

		public ProductTypeExtraResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new ProductTypeExtraResource(_apiContext.CloneWith(contextModification), _dataViewMode);
		}

		public ProductTypeExtraResource(IApiContext apiContext, DataViewMode dataViewMode) 
		{
			_apiContext = apiContext;
			_dataViewMode = dataViewMode;
		}
				
		/// <summary>
		/// Retrieves a list of extra attributes defined for the specified product type.
		/// </summary>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeInProductType"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var producttypeextra = new ProductTypeExtra();
		///   var attributeInProductType = producttypeextra.GetExtras(_dataViewMode,  productTypeId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> GetExtras(int productTypeId)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypeExtraClient.GetExtrasClient(_dataViewMode,  productTypeId);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a list of extra attributes defined for the specified product type.
		/// </summary>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeInProductType"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var producttypeextra = new ProductTypeExtra();
		///   var attributeInProductType = await producttypeextra.GetExtrasAsync(_dataViewMode,  productTypeId);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType>> GetExtrasAsync(int productTypeId)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypeExtraClient.GetExtrasClient(_dataViewMode,  productTypeId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of an extra attribute definition for the specified product type.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productTypeId">Identifier of the product type whose extra is being retrieved.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeInProductType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttypeextra = new ProductTypeExtra();
		///   var attributeInProductType = producttypeextra.GetExtra(_dataViewMode,  productTypeId,  attributeFQN,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.AttributeInProductType GetExtra(int productTypeId, string attributeFQN, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypeExtraClient.GetExtraClient(_dataViewMode,  productTypeId,  attributeFQN,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the details of an extra attribute definition for the specified product type.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productTypeId">Identifier of the product type whose extra is being retrieved.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeInProductType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttypeextra = new ProductTypeExtra();
		///   var attributeInProductType = await producttypeextra.GetExtraAsync(_dataViewMode,  productTypeId,  attributeFQN,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> GetExtraAsync(int productTypeId, string attributeFQN, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypeExtraClient.GetExtraClient(_dataViewMode,  productTypeId,  attributeFQN,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Assigns a defined extra attribute to the product type based on the information supplied in the request.
		/// </summary>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="attributeInProductType">The properties of the extra attribute definition for this product type assignment.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeInProductType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttypeextra = new ProductTypeExtra();
		///   var attributeInProductType = producttypeextra.AddExtra(_dataViewMode,  attributeInProductType,  productTypeId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.AttributeInProductType AddExtra(Mozu.Api.Contracts.ProductAdmin.AttributeInProductType attributeInProductType, int productTypeId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypeExtraClient.AddExtraClient(_dataViewMode,  attributeInProductType,  productTypeId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Assigns a defined extra attribute to the product type based on the information supplied in the request.
		/// </summary>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="attributeInProductType">The properties of the extra attribute definition for this product type assignment.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeInProductType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttypeextra = new ProductTypeExtra();
		///   var attributeInProductType = await producttypeextra.AddExtraAsync(_dataViewMode,  attributeInProductType,  productTypeId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> AddExtraAsync(Mozu.Api.Contracts.ProductAdmin.AttributeInProductType attributeInProductType, int productTypeId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypeExtraClient.AddExtraClient(_dataViewMode,  attributeInProductType,  productTypeId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Update the definition of an extra attribute for the specified product type.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="attributeInProductType">The properties of the extra attribute definition to update for the product type.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeInProductType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttypeextra = new ProductTypeExtra();
		///   var attributeInProductType = producttypeextra.UpdateExtra(_dataViewMode,  attributeInProductType,  productTypeId,  attributeFQN,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.AttributeInProductType UpdateExtra(Mozu.Api.Contracts.ProductAdmin.AttributeInProductType attributeInProductType, int productTypeId, string attributeFQN, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypeExtraClient.UpdateExtraClient(_dataViewMode,  attributeInProductType,  productTypeId,  attributeFQN,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Update the definition of an extra attribute for the specified product type.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="attributeInProductType">The properties of the extra attribute definition to update for the product type.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeInProductType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttypeextra = new ProductTypeExtra();
		///   var attributeInProductType = await producttypeextra.UpdateExtraAsync(_dataViewMode,  attributeInProductType,  productTypeId,  attributeFQN,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> UpdateExtraAsync(Mozu.Api.Contracts.ProductAdmin.AttributeInProductType attributeInProductType, int productTypeId, string attributeFQN, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypeExtraClient.UpdateExtraClient(_dataViewMode,  attributeInProductType,  productTypeId,  attributeFQN,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Removes an extra attribute definition from the specified product type.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var producttypeextra = new ProductTypeExtra();
		///   producttypeextra.DeleteExtra(_dataViewMode,  productTypeId,  attributeFQN);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteExtra(int productTypeId, string attributeFQN)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypeExtraClient.DeleteExtraClient(_dataViewMode,  productTypeId,  attributeFQN);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Removes an extra attribute definition from the specified product type.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var producttypeextra = new ProductTypeExtra();
		///   await producttypeextra.DeleteExtraAsync(_dataViewMode,  productTypeId,  attributeFQN);
		/// </code>
		/// </example>
		public virtual async Task DeleteExtraAsync(int productTypeId, string attributeFQN)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypeExtraClient.DeleteExtraClient(_dataViewMode,  productTypeId,  attributeFQN);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


