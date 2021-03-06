
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
	/// Retrieves the details of a price list. The details may contain a hierarchy of ancestor and/or descendant price lists dependening on your configuration.
	/// </summary>
	public partial class PriceListClient 	{
		
		/// <summary>
		/// Retrieves the details of the specified price list.
		/// </summary>
		/// <param name="priceListCode">The unique code of the price list for which you want to retrieve the details.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
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
		/// Retrieves the details of a price list to which the specified customer resolves. This is primarly used when creating an offline order for a shopper.You can use this operation alongside custom Arc.js actions to alter the price list to which a shopper resolves.
		/// </summary>
		/// <param name="customerAccountId">The unique identifier of the customer account for which to retrieve wish lists.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
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


