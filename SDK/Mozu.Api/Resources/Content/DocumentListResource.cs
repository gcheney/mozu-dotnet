
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

namespace Mozu.Api.Resources.Content
{
	/// <summary>
	/// Use the document lists resource to organize your site's documents into a hierarchy. Document lists can contain documents, folders, and complete hierarchies of folders, which contain documents with unique names.
	/// </summary>
	public partial class DocumentListResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		private readonly DataViewMode _dataViewMode;
		
		public DocumentListResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
			_dataViewMode = DataViewMode.Live;
		}

		public DocumentListResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new DocumentListResource(_apiContext.CloneWith(contextModification));
		}

		public DocumentListResource(IApiContext apiContext, DataViewMode dataViewMode) 
		{
			_apiContext = apiContext;
			_dataViewMode = dataViewMode;
		}
				
		/// <summary>
		/// Retrieves a collection of document lists.
		/// </summary>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.DocumentListCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documentlist = new DocumentList();
		///   var documentListCollection = documentlist.GetDocumentLists(_dataViewMode,  pageSize,  startIndex,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Content.DocumentListCollection GetDocumentLists(int? pageSize =  null, int? startIndex =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.DocumentListCollection> response;
			var client = Mozu.Api.Clients.Content.DocumentListClient.GetDocumentListsClient(_dataViewMode,  pageSize,  startIndex,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Content.DocumentListCollection> GetDocumentListsAsync(int? pageSize =  null, int? startIndex =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.DocumentListCollection> response;
			var client = Mozu.Api.Clients.Content.DocumentListClient.GetDocumentListsClient(_dataViewMode,  pageSize,  startIndex,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieve the details of a document list by providing the list name.
		/// </summary>
		/// <param name="documentListName">The name of the document list.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.DocumentList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documentlist = new DocumentList();
		///   var documentList = documentlist.GetDocumentList(_dataViewMode,  documentListName,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Content.DocumentList GetDocumentList(string documentListName, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.DocumentList> response;
			var client = Mozu.Api.Clients.Content.DocumentListClient.GetDocumentListClient(_dataViewMode,  documentListName,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Content.DocumentList> GetDocumentListAsync(string documentListName, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.DocumentList> response;
			var client = Mozu.Api.Clients.Content.DocumentListClient.GetDocumentListClient(_dataViewMode,  documentListName,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="list"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.DocumentList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documentlist = new DocumentList();
		///   var documentList = documentlist.CreateDocumentList(_dataViewMode,  list,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Content.DocumentList CreateDocumentList(Mozu.Api.Contracts.Content.DocumentList list, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.DocumentList> response;
			var client = Mozu.Api.Clients.Content.DocumentListClient.CreateDocumentListClient(_dataViewMode,  list,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Content.DocumentList> CreateDocumentListAsync(Mozu.Api.Contracts.Content.DocumentList list, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.DocumentList> response;
			var client = Mozu.Api.Clients.Content.DocumentListClient.CreateDocumentListClient(_dataViewMode,  list,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="documentListName"></param>
		/// <param name="responseFields"></param>
		/// <param name="list"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.DocumentList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documentlist = new DocumentList();
		///   var documentList = documentlist.UpdateDocumentList( list,  documentListName,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Content.DocumentList UpdateDocumentList(Mozu.Api.Contracts.Content.DocumentList list, string documentListName, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.DocumentList> response;
			var client = Mozu.Api.Clients.Content.DocumentListClient.UpdateDocumentListClient( list,  documentListName,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Content.DocumentList> UpdateDocumentListAsync(Mozu.Api.Contracts.Content.DocumentList list, string documentListName, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.DocumentList> response;
			var client = Mozu.Api.Clients.Content.DocumentListClient.UpdateDocumentListClient( list,  documentListName,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="documentId"></param>
		/// <param name="stream"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var documentlist = new DocumentList();
		///   documentlist.LegacyR4_UpdateDocumentContent( stream,  documentId,  contentType);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void LegacyR4_UpdateDocumentContent(System.IO.Stream stream, string documentId, String  contentType= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Content.DocumentListClient.LegacyR4_UpdateDocumentContentClient( stream,  documentId,  contentType);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		public virtual async Task LegacyR4_UpdateDocumentContentAsync(System.IO.Stream stream, string documentId, String  contentType= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Content.DocumentListClient.LegacyR4_UpdateDocumentContentClient( stream,  documentId,  contentType);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="documentListName"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var documentlist = new DocumentList();
		///   documentlist.DeleteDocumentList( documentListName);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteDocumentList(string documentListName)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Content.DocumentListClient.DeleteDocumentListClient( documentListName);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		public virtual async Task DeleteDocumentListAsync(string documentListName)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Content.DocumentListClient.DeleteDocumentListClient( documentListName);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


