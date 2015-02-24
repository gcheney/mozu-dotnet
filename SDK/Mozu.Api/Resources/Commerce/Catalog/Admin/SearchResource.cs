
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
	/// The Search resource manages all settings and options for providing product search on your site.
	/// </summary>
	public partial class SearchResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public SearchResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public SearchResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new SearchResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Get site search settings
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.SearchSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var searchSettings = search.GetSettings( responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.SearchSettings GetSettings(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.SearchSettings> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.GetSettingsClient( responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Get site search settings
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.SearchSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var searchSettings = await search.GetSettingsAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.SearchSettings> GetSettingsAsync(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.SearchSettings> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.GetSettingsClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Adds or Updates (Upsert) the Search Settings for a specific site
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="settings">The settings to control product search and indexing behavior.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.SearchSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var searchSettings = search.UpdateSettings( settings,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.SearchSettings UpdateSettings(Mozu.Api.Contracts.ProductAdmin.SearchSettings settings, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.SearchSettings> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.UpdateSettingsClient( settings,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Adds or Updates (Upsert) the Search Settings for a specific site
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="settings">The settings to control product search and indexing behavior.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.SearchSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var searchSettings = await search.UpdateSettingsAsync( settings,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.SearchSettings> UpdateSettingsAsync(Mozu.Api.Contracts.ProductAdmin.SearchSettings settings, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.SearchSettings> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.UpdateSettingsClient( settings,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


