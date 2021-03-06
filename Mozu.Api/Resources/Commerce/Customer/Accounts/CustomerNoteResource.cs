
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

namespace Mozu.Api.Resources.Commerce.Customer.Accounts
{
	/// <summary>
	/// This resources manages notes for a customer account. For example, a client can track a shopper's interests or complaints. Only clients can add and view notes. Shoppers cannot view these notes from the My Account page.
	/// </summary>
	public partial class CustomerNoteResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public CustomerNoteResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public CustomerNoteResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new CustomerNoteResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves the contents of a particular note attached to a specified customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="noteId">Unique identifier of a particular note to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerNote"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customernote = new CustomerNote();
		///   var customerNote = customernote.GetAccountNote( accountId,  noteId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.CustomerNote GetAccountNote(int accountId, int noteId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerNote> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerNoteClient.GetAccountNoteClient( accountId,  noteId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the contents of a particular note attached to a specified customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="noteId">Unique identifier of a particular note to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerNote"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customernote = new CustomerNote();
		///   var customerNote = await customernote.GetAccountNoteAsync( accountId,  noteId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerNote> GetAccountNoteAsync(int accountId, int noteId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerNote> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerNoteClient.GetAccountNoteClient( accountId,  noteId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves a list of notes added to a customer account according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerNoteCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customernote = new CustomerNote();
		///   var customerNoteCollection = customernote.GetAccountNotes( accountId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.CustomerNoteCollection GetAccountNotes(int accountId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerNoteCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerNoteClient.GetAccountNotesClient( accountId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a list of notes added to a customer account according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerNoteCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customernote = new CustomerNote();
		///   var customerNoteCollection = await customernote.GetAccountNotesAsync( accountId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerNoteCollection> GetAccountNotesAsync(int accountId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerNoteCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerNoteClient.GetAccountNotesClient( accountId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Adds a new note to the specified customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="note">Properties of a note configured for a customer account.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerNote"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customernote = new CustomerNote();
		///   var customerNote = customernote.AddAccountNote( note,  accountId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.CustomerNote AddAccountNote(Mozu.Api.Contracts.Customer.CustomerNote note, int accountId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerNote> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerNoteClient.AddAccountNoteClient( note,  accountId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Adds a new note to the specified customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="note">Properties of a note configured for a customer account.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerNote"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customernote = new CustomerNote();
		///   var customerNote = await customernote.AddAccountNoteAsync( note,  accountId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerNote> AddAccountNoteAsync(Mozu.Api.Contracts.Customer.CustomerNote note, int accountId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerNote> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerNoteClient.AddAccountNoteClient( note,  accountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Modifies an existing note for a customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="noteId">Unique identifier of a particular note to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="note">Properties of a note configured for a customer account.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerNote"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customernote = new CustomerNote();
		///   var customerNote = customernote.UpdateAccountNote( note,  accountId,  noteId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.CustomerNote UpdateAccountNote(Mozu.Api.Contracts.Customer.CustomerNote note, int accountId, int noteId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerNote> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerNoteClient.UpdateAccountNoteClient( note,  accountId,  noteId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Modifies an existing note for a customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="noteId">Unique identifier of a particular note to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="note">Properties of a note configured for a customer account.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerNote"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customernote = new CustomerNote();
		///   var customerNote = await customernote.UpdateAccountNoteAsync( note,  accountId,  noteId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerNote> UpdateAccountNoteAsync(Mozu.Api.Contracts.Customer.CustomerNote note, int accountId, int noteId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerNote> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerNoteClient.UpdateAccountNoteClient( note,  accountId,  noteId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Removes a note from the specified customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="noteId">Unique identifier of a particular note to retrieve.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customernote = new CustomerNote();
		///   customernote.DeleteAccountNote( accountId,  noteId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteAccountNote(int accountId, int noteId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerNoteClient.DeleteAccountNoteClient( accountId,  noteId);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Removes a note from the specified customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="noteId">Unique identifier of a particular note to retrieve.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customernote = new CustomerNote();
		///   await customernote.DeleteAccountNoteAsync( accountId,  noteId);
		/// </code>
		/// </example>
		public virtual async Task DeleteAccountNoteAsync(int accountId, int noteId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerNoteClient.DeleteAccountNoteClient( accountId,  noteId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


