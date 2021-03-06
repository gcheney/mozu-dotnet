
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

namespace Mozu.Api.Resources.Commerce
{
	/// <summary>
	/// Use the TargetRules resource to manage your target rules for products and zones. For example, you can set specific rules that dictate shipping options for specific products.
	/// </summary>
	public partial class TargetRuleResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public TargetRuleResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public TargetRuleResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new TargetRuleResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves a list of target rules and their details according to any specified facets, filter criteria, and sort options.
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for a list of supported filters.</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for more information.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.TargetRuleCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   var targetRuleCollection = targetrule.GetTargetRules( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ShippingAdmin.TargetRuleCollection GetTargetRules(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.TargetRuleCollection> response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.GetTargetRulesClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a list of target rules and their details according to any specified facets, filter criteria, and sort options.
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for a list of supported filters.</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for more information.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.TargetRuleCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   var targetRuleCollection = await targetrule.GetTargetRulesAsync( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ShippingAdmin.TargetRuleCollection> GetTargetRulesAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.TargetRuleCollection> response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.GetTargetRulesClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of the specified target rule.
		/// </summary>
		/// <param name="code">User-defined code that uniqely identifies the channel group.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.TargetRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   var targetRule = targetrule.GetTargetRule( code,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ShippingAdmin.TargetRule GetTargetRule(string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.TargetRule> response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.GetTargetRuleClient( code,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the details of the specified target rule.
		/// </summary>
		/// <param name="code">User-defined code that uniqely identifies the channel group.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.TargetRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   var targetRule = await targetrule.GetTargetRuleAsync( code,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ShippingAdmin.TargetRule> GetTargetRuleAsync(string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.TargetRule> response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.GetTargetRuleClient( code,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Creates a new target rule.
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="targetRule">The details of the new target rule.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.TargetRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   var targetRule = targetrule.CreateTargetRule( targetRule,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ShippingAdmin.TargetRule CreateTargetRule(Mozu.Api.Contracts.ShippingAdmin.TargetRule targetRule, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.TargetRule> response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.CreateTargetRuleClient( targetRule,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Creates a new target rule.
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="targetRule">The details of the new target rule.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.TargetRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   var targetRule = await targetrule.CreateTargetRuleAsync( targetRule,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ShippingAdmin.TargetRule> CreateTargetRuleAsync(Mozu.Api.Contracts.ShippingAdmin.TargetRule targetRule, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.TargetRule> response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.CreateTargetRuleClient( targetRule,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Validates the details of a target rule.
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="targetRule">The details of the target rule you want to validate.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   targetrule.ValidateTargetRule( targetRule);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void ValidateTargetRule(Mozu.Api.Contracts.ShippingAdmin.TargetRule targetRule)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.ValidateTargetRuleClient( targetRule);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Validates the details of a target rule.
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="targetRule">The details of the target rule you want to validate.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   await targetrule.ValidateTargetRuleAsync( targetRule);
		/// </code>
		/// </example>
		public virtual async Task ValidateTargetRuleAsync(Mozu.Api.Contracts.ShippingAdmin.TargetRule targetRule)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.ValidateTargetRuleClient( targetRule);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// Updates the details of the specified target rule.
		/// </summary>
		/// <param name="code">User-defined code that uniqely identifies the channel group.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="targetRule">The details of the updated target rule.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.TargetRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   var targetRule = targetrule.UpdateTargetRule( targetRule,  code,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ShippingAdmin.TargetRule UpdateTargetRule(Mozu.Api.Contracts.ShippingAdmin.TargetRule targetRule, string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.TargetRule> response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.UpdateTargetRuleClient( targetRule,  code,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates the details of the specified target rule.
		/// </summary>
		/// <param name="code">User-defined code that uniqely identifies the channel group.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="targetRule">The details of the updated target rule.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.TargetRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   var targetRule = await targetrule.UpdateTargetRuleAsync( targetRule,  code,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ShippingAdmin.TargetRule> UpdateTargetRuleAsync(Mozu.Api.Contracts.ShippingAdmin.TargetRule targetRule, string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.TargetRule> response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.UpdateTargetRuleClient( targetRule,  code,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes the specified target rule.
		/// </summary>
		/// <param name="code">User-defined code that uniqely identifies the channel group.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   targetrule.DeleteTargetRule( code);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteTargetRule(string code)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.DeleteTargetRuleClient( code);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Deletes the specified target rule.
		/// </summary>
		/// <param name="code">User-defined code that uniqely identifies the channel group.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   await targetrule.DeleteTargetRuleAsync( code);
		/// </code>
		/// </example>
		public virtual async Task DeleteTargetRuleAsync(string code)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.DeleteTargetRuleClient( code);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


