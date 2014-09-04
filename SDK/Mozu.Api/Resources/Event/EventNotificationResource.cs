
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

namespace Mozu.Api.Resources.Event
{
	/// <summary>
	/// Events are notifications Mozu publishes to the application when a create, read, update, or delete operation is performed. If the application subscribes to the event, you can use the Events resource to query for recent events Mozu published to your application or events that were not published successfully.
	/// </summary>
	public partial class EventNotificationResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public EventNotificationResource() 
		{
			_apiContext = null;
		}
		 public EventNotificationResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public EventNotificationResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new EventNotificationResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves a list of events.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Event.EventCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var eventnotification = new EventNotification();
		///   var eventCollection = eventnotification.GetEvents( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Event.EventCollection GetEvents(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Event.EventCollection> response;
			var client = Mozu.Api.Clients.Event.EventNotificationClient.GetEventsClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Event.EventCollection> GetEventsAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Event.EventCollection> response;
			var client = Mozu.Api.Clients.Event.EventNotificationClient.GetEventsClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves an event by providing the event ID.
		/// </summary>
		/// <param name="eventId">The unique identifier of the event being retrieved. An event is a notification about a create, read, update, or delete on an order, product, discount or category.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Event.Event"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var eventnotification = new EventNotification();
		///   var event = eventnotification.GetEvent( eventId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Event.Event GetEvent(string eventId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Event.Event> response;
			var client = Mozu.Api.Clients.Event.EventNotificationClient.GetEventClient( eventId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.Event.Event> GetEventAsync(string eventId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Event.Event> response;
			var client = Mozu.Api.Clients.Event.EventNotificationClient.GetEventClient( eventId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


