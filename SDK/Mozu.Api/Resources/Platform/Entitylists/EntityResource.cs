
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

namespace Mozu.Api.Resources.Platform.Entitylists
{
	/// <summary>
	/// Entities are JSON entries within the MZDB (Mozu Mongo DB) for handling large data sets to heavily filter (&gt;2,000 items). Each entity is associated to an EntityList with schema, rules, and formatting for storing the content. This content can be accessed via the Mozu API and Mozu Hypr tags.
	/// </summary>
	public partial class EntityResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public EntityResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public EntityResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new EntityResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves an entity with an associated entity list and context level at tenant, master catalog, catalog, or site. 
		/// </summary>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// JObject
		/// </returns>
		/// <example>
		/// <code>
		///   var entity = new Entity();
		///   var json = entity.GetEntity( entityListFullName,  id,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual JObject GetEntity(string entityListFullName, string id, string responseFields =  null)
		{
			MozuClient<JObject> response;
			var client = Mozu.Api.Clients.Platform.Entitylists.EntityClient.GetEntityClient( entityListFullName,  id,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves an entity with an associated entity list and context level at tenant, master catalog, catalog, or site. 
		/// </summary>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// JObject
		/// </returns>
		/// <example>
		/// <code>
		///   var entity = new Entity();
		///   var json = await entity.GetEntityAsync( entityListFullName,  id,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<JObject> GetEntityAsync(string entityListFullName, string id, string responseFields =  null)
		{
			MozuClient<JObject> response;
			var client = Mozu.Api.Clients.Platform.Entitylists.EntityClient.GetEntityClient( entityListFullName,  id,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves a collection of entities with an associated entity list and context level at tenant, master catalog, catalog, or site. 
		/// </summary>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The amount is divided and displayed on the `pageCount `amount of pages. The default is 20 and maximum value is 200 per page.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a `pageSize `of 25, to get the 51st through the 75th items, use `startIndex=3`.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.MZDB.EntityCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var entity = new Entity();
		///   var entityCollection = entity.GetEntities( entityListFullName,  pageSize,  startIndex,  filter,  sortBy,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.MZDB.EntityCollection GetEntities(string entityListFullName, int? pageSize =  null, int? startIndex =  null, string filter =  null, string sortBy =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.MZDB.EntityCollection> response;
			var client = Mozu.Api.Clients.Platform.Entitylists.EntityClient.GetEntitiesClient( entityListFullName,  pageSize,  startIndex,  filter,  sortBy,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a collection of entities with an associated entity list and context level at tenant, master catalog, catalog, or site. 
		/// </summary>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The amount is divided and displayed on the `pageCount `amount of pages. The default is 20 and maximum value is 200 per page.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a `pageSize `of 25, to get the 51st through the 75th items, use `startIndex=3`.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.MZDB.EntityCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var entity = new Entity();
		///   var entityCollection = await entity.GetEntitiesAsync( entityListFullName,  pageSize,  startIndex,  filter,  sortBy,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.MZDB.EntityCollection> GetEntitiesAsync(string entityListFullName, int? pageSize =  null, int? startIndex =  null, string filter =  null, string sortBy =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.MZDB.EntityCollection> response;
			var client = Mozu.Api.Clients.Platform.Entitylists.EntityClient.GetEntitiesClient( entityListFullName,  pageSize,  startIndex,  filter,  sortBy,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Inserts a new entity per the entered item, the entity list full name, and associated response fields. 
		/// </summary>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="item">JSON code for objects.</param>
		/// <returns>
		/// JObject
		/// </returns>
		/// <example>
		/// <code>
		///   var entity = new Entity();
		///   var json = entity.InsertEntity( item,  entityListFullName,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual JObject InsertEntity(JObject item, string entityListFullName, string responseFields =  null)
		{
			MozuClient<JObject> response;
			var client = Mozu.Api.Clients.Platform.Entitylists.EntityClient.InsertEntityClient( item,  entityListFullName,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Inserts a new entity per the entered item, the entity list full name, and associated response fields. 
		/// </summary>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="item">JSON code for objects.</param>
		/// <returns>
		/// JObject
		/// </returns>
		/// <example>
		/// <code>
		///   var entity = new Entity();
		///   var json = await entity.InsertEntityAsync( item,  entityListFullName,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<JObject> InsertEntityAsync(JObject item, string entityListFullName, string responseFields =  null)
		{
			MozuClient<JObject> response;
			var client = Mozu.Api.Clients.Platform.Entitylists.EntityClient.InsertEntityClient( item,  entityListFullName,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates the content and associations for an existing entity.
		/// </summary>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="item">JSON code for objects.</param>
		/// <returns>
		/// JObject
		/// </returns>
		/// <example>
		/// <code>
		///   var entity = new Entity();
		///   var json = entity.UpdateEntity( item,  entityListFullName,  id,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual JObject UpdateEntity(JObject item, string entityListFullName, string id, string responseFields =  null)
		{
			MozuClient<JObject> response;
			var client = Mozu.Api.Clients.Platform.Entitylists.EntityClient.UpdateEntityClient( item,  entityListFullName,  id,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates the content and associations for an existing entity.
		/// </summary>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="item">JSON code for objects.</param>
		/// <returns>
		/// JObject
		/// </returns>
		/// <example>
		/// <code>
		///   var entity = new Entity();
		///   var json = await entity.UpdateEntityAsync( item,  entityListFullName,  id,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<JObject> UpdateEntityAsync(JObject item, string entityListFullName, string id, string responseFields =  null)
		{
			MozuClient<JObject> response;
			var client = Mozu.Api.Clients.Platform.Entitylists.EntityClient.UpdateEntityClient( item,  entityListFullName,  id,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes an entity depending on the context of tenant, master catalog, catalog, or site level. Entities are associated to an entity list (schema and formatting) for displaying within a namespace and context level.
		/// </summary>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var entity = new Entity();
		///   entity.DeleteEntity( entityListFullName,  id);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteEntity(string entityListFullName, string id)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Platform.Entitylists.EntityClient.DeleteEntityClient( entityListFullName,  id);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Deletes an entity depending on the context of tenant, master catalog, catalog, or site level. Entities are associated to an entity list (schema and formatting) for displaying within a namespace and context level.
		/// </summary>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var entity = new Entity();
		///   await entity.DeleteEntityAsync( entityListFullName,  id);
		/// </code>
		/// </example>
		public virtual async Task DeleteEntityAsync(string entityListFullName, string id)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Platform.Entitylists.EntityClient.DeleteEntityClient( entityListFullName,  id);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


