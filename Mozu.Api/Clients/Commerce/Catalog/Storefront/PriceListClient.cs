
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

namespace Mozu.Api.Clients.Commerce.Catalog.Storefront
{
	/// <summary>
	/// 
	/// </summary>
	public partial class PriceListClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="priceListCode"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductRuntime.PriceList"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPriceList( priceListCode,  responseFields);
		///   var priceListClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductRuntime.PriceList> GetPriceListClient(string priceListCode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Storefront.PriceListUrl.GetPriceListUrl(priceListCode, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductRuntime.PriceList>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="customerAccountId"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductRuntime.ResolvedPriceList"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetResolvedPriceList( customerAccountId,  responseFields);
		///   var resolvedPriceListClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductRuntime.ResolvedPriceList> GetResolvedPriceListClient(int? customerAccountId =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Storefront.PriceListUrl.GetResolvedPriceListUrl(customerAccountId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductRuntime.ResolvedPriceList>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


