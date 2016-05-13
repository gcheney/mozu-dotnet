
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

namespace Mozu.Api.Resources.Commerce.Catalog.Storefront
{
	/// <summary>
	/// 
	/// </summary>
	public partial class PriceListResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public PriceListResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public PriceListResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new PriceListResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// 
		/// </summary>
		/// <param name="priceListCode"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.PriceList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelist = new PriceList();
		///   var priceList = pricelist.GetPriceList( priceListCode,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductRuntime.PriceList GetPriceList(string priceListCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.PriceList> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.PriceListClient.GetPriceListClient( priceListCode,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="priceListCode"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.PriceList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelist = new PriceList();
		///   var priceList = await pricelist.GetPriceListAsync( priceListCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductRuntime.PriceList> GetPriceListAsync(string priceListCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.PriceList> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.PriceListClient.GetPriceListClient( priceListCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="customerAccountId"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.ResolvedPriceList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelist = new PriceList();
		///   var resolvedPriceList = pricelist.GetResolvedPriceList( customerAccountId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductRuntime.ResolvedPriceList GetResolvedPriceList(int? customerAccountId =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.ResolvedPriceList> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.PriceListClient.GetResolvedPriceListClient( customerAccountId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="customerAccountId"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.ResolvedPriceList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pricelist = new PriceList();
		///   var resolvedPriceList = await pricelist.GetResolvedPriceListAsync( customerAccountId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductRuntime.ResolvedPriceList> GetResolvedPriceListAsync(int? customerAccountId =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.ResolvedPriceList> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.PriceListClient.GetResolvedPriceListClient( customerAccountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


