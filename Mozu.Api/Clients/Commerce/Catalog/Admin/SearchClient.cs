
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
	/// 
	/// </summary>
	public partial class SearchClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="searchTuningRuleCode"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetSearchTuningRule( searchTuningRuleCode,  responseFields);
		///   var searchTuningRuleClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule> GetSearchTuningRuleClient(string searchTuningRuleCode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SearchUrl.GetSearchTuningRuleUrl(searchTuningRuleCode, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetSearchTuningRules( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		///   var searchTuningRuleCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleCollection> GetSearchTuningRulesClient(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SearchUrl.GetSearchTuningRulesUrl(startIndex, pageSize, sortBy, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleSortFields"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetSearchTuningRuleSortFields( responseFields);
		///   var searchTuningRuleSortFieldsClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleSortFields> GetSearchTuningRuleSortFieldsClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SearchUrl.GetSearchTuningRuleSortFieldsUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleSortFields>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.SearchSettings"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetSettings( responseFields);
		///   var searchSettingsClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.SearchSettings> GetSettingsClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SearchUrl.GetSettingsUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.SearchSettings>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves a collection of synonyms definitions for product searches. Synonyms aid with determining matches for entered searches.
		/// </summary>
		/// <param name="localeCode">The two character country code that sets the locale, such as US for United States. Sites, tenants, and catalogs use locale codes for localizing content, such as translated product text per supported country.</param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinitionCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetSynonymDefinitionCollection( localeCode,  responseFields);
		///   var synonymDefinitionCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinitionCollection> GetSynonymDefinitionCollectionClient(string localeCode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SearchUrl.GetSynonymDefinitionCollectionUrl(localeCode, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinitionCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="searchTuningRuleIn"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddSearchTuningRule( searchTuningRuleIn,  responseFields);
		///   var searchTuningRuleClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule> AddSearchTuningRuleClient(Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule searchTuningRuleIn, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SearchUrl.AddSearchTuningRuleUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule>(searchTuningRuleIn);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="searchTuningRuleSortFieldsIn"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleSortFields"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateSearchTuningRuleSortFields( searchTuningRuleSortFieldsIn,  responseFields);
		///   var searchTuningRuleSortFieldsClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleSortFields> UpdateSearchTuningRuleSortFieldsClient(Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleSortFields searchTuningRuleSortFieldsIn, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SearchUrl.UpdateSearchTuningRuleSortFieldsUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleSortFields>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleSortFields>(searchTuningRuleSortFieldsIn);
			return mozuClient;

		}

		/// <summary>
		/// Updates synonym definitions for product searches. Synonyms aid with determining matches for entered searches.
		/// </summary>
		/// <param name="localeCode">The two character country code that sets the locale, such as US for United States. Sites, tenants, and catalogs use locale codes for localizing content, such as translated product text per supported country.</param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="collection">Collection of synonym definitions used for determining search results.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinitionCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateSynonymDefinitionCollection( collection,  localeCode,  responseFields);
		///   var synonymDefinitionCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinitionCollection> UpdateSynonymDefinitionCollectionClient(Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinitionCollection collection, string localeCode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SearchUrl.UpdateSynonymDefinitionCollectionUrl(localeCode, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinitionCollection>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.Search.SynonymDefinitionCollection>(collection);
			return mozuClient;

		}

		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="searchTuningRuleCode"></param>
		/// <param name="searchTuningRuleIn"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateSearchTuningRule( searchTuningRuleIn,  searchTuningRuleCode,  responseFields);
		///   var searchTuningRuleClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule> UpdateSearchTuningRuleClient(Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule searchTuningRuleIn, string searchTuningRuleCode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SearchUrl.UpdateSearchTuningRuleUrl(searchTuningRuleCode, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule>(searchTuningRuleIn);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="settings"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.SearchSettings"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateSettings( settings,  responseFields);
		///   var searchSettingsClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.SearchSettings> UpdateSettingsClient(Mozu.Api.Contracts.ProductAdmin.SearchSettings settings, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SearchUrl.UpdateSettingsUrl(responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.SearchSettings>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.SearchSettings>(settings);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="searchTuningRuleCode"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteSearchTuningRule( searchTuningRuleCode);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteSearchTuningRuleClient(string searchTuningRuleCode)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.SearchUrl.DeleteSearchTuningRuleUrl(searchTuningRuleCode);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


