
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

namespace Mozu.Api.Resources.Commerce.Customer
{
	/// <summary>
	/// Use the Customer Credits resource to manage the store credit associated with a customer account. Store credit can represent a static amount the customer can redeem at any of the tenant's sites, or a gift card registered for a customer account. At this time, gift card functionality is reserved for future use.
	/// </summary>
	public partial class CreditResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public CreditResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public CreditResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new CreditResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves a list of store credits applied to customer accounts, according any filter and sort criteria specified in the request.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.Credit.CreditCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var credit = new Credit();
		///   var creditCollection = credit.GetCredits( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.Credit.CreditCollection GetCredits(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.Credit.CreditCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CreditClient.GetCreditsClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a list of store credits applied to customer accounts, according any filter and sort criteria specified in the request.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.Credit.CreditCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var credit = new Credit();
		///   var creditCollection = await credit.GetCreditsAsync( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.Credit.CreditCollection> GetCreditsAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.Credit.CreditCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CreditClient.GetCreditsClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of a store credit applied to a customer account.
		/// </summary>
		/// <param name="code">User-defined code that identifies the store credit to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.Credit.Credit"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var credit = new Credit();
		///   var credit = credit.GetCredit( code,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.Credit.Credit GetCredit(string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.Credit.Credit> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CreditClient.GetCreditClient( code,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the details of a store credit applied to a customer account.
		/// </summary>
		/// <param name="code">User-defined code that identifies the store credit to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.Credit.Credit"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var credit = new Credit();
		///   var credit = await credit.GetCreditAsync( code,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.Credit.Credit> GetCreditAsync(string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.Credit.Credit> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CreditClient.GetCreditClient( code,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Creates a new store credit for the customer account specified in the request.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="credit">Properties of the store credit to create.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.Credit.Credit"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var credit = new Credit();
		///   var credit = credit.AddCredit( credit,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.Credit.Credit AddCredit(Mozu.Api.Contracts.Customer.Credit.Credit credit, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.Credit.Credit> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CreditClient.AddCreditClient( credit,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Creates a new store credit for the customer account specified in the request.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="credit">Properties of the store credit to create.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.Credit.Credit"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var credit = new Credit();
		///   var credit = await credit.AddCreditAsync( credit,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.Credit.Credit> AddCreditAsync(Mozu.Api.Contracts.Customer.Credit.Credit credit, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.Credit.Credit> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CreditClient.AddCreditClient( credit,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Associates an unclaimed customer credit with the shopper user authenticated in the request header.
		/// </summary>
		/// <param name="code">The code that represents the credit to claim for the shopper.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.Credit.Credit"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var credit = new Credit();
		///   var credit = credit.AssociateCreditToShopper( code,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.Credit.Credit AssociateCreditToShopper(string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.Credit.Credit> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CreditClient.AssociateCreditToShopperClient( code,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Associates an unclaimed customer credit with the shopper user authenticated in the request header.
		/// </summary>
		/// <param name="code">The code that represents the credit to claim for the shopper.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.Credit.Credit"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var credit = new Credit();
		///   var credit = await credit.AssociateCreditToShopperAsync( code,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.Credit.Credit> AssociateCreditToShopperAsync(string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.Credit.Credit> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CreditClient.AssociateCreditToShopperClient( code,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="code"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var credit = new Credit();
		///   credit.ResendCreditCreatedEmail( code);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void ResendCreditCreatedEmail(string code)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.CreditClient.ResendCreditCreatedEmailClient( code);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="code"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var credit = new Credit();
		///   await credit.ResendCreditCreatedEmailAsync( code);
		/// </code>
		/// </example>
		public virtual async Task ResendCreditCreatedEmailAsync(string code)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.CreditClient.ResendCreditCreatedEmailClient( code);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// Updates one or more properties of a defined store credit applied to a customer account.
		/// </summary>
		/// <param name="code">User-defined code of the store credit to update.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="credit">Properties of the store credit to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.Credit.Credit"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var credit = new Credit();
		///   var credit = credit.UpdateCredit( credit,  code,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.Credit.Credit UpdateCredit(Mozu.Api.Contracts.Customer.Credit.Credit credit, string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.Credit.Credit> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CreditClient.UpdateCreditClient( credit,  code,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates one or more properties of a defined store credit applied to a customer account.
		/// </summary>
		/// <param name="code">User-defined code of the store credit to update.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="credit">Properties of the store credit to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.Credit.Credit"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var credit = new Credit();
		///   var credit = await credit.UpdateCreditAsync( credit,  code,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.Credit.Credit> UpdateCreditAsync(Mozu.Api.Contracts.Customer.Credit.Credit credit, string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.Credit.Credit> response;
			var client = Mozu.Api.Clients.Commerce.Customer.CreditClient.UpdateCreditClient( credit,  code,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes a store credit previously applied to a customer account.
		/// </summary>
		/// <param name="code">User-defined code of the store credit to delete.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var credit = new Credit();
		///   credit.DeleteCredit( code);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteCredit(string code)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.CreditClient.DeleteCreditClient( code);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Deletes a store credit previously applied to a customer account.
		/// </summary>
		/// <param name="code">User-defined code of the store credit to delete.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var credit = new Credit();
		///   await credit.DeleteCreditAsync( code);
		/// </code>
		/// </example>
		public virtual async Task DeleteCreditAsync(string code)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.CreditClient.DeleteCreditClient( code);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


