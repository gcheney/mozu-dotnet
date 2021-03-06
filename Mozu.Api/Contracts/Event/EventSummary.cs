
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


namespace Mozu.Api.Contracts.Event
{
		///
		///	Properties of events as a summary of actions, data, and responses.
		///
		public class EventSummary
		{
			///
			///The unique identifier for the product catalog. Catalogs are part of a master catalog.
			///
			public int? CatalogId { get; set; }

			///
			///The unique identifier of the API request associated with the event action, which might contain multiple actions.
			///
			public string CorrelationId { get; set; }

			///
			///The date and time in UTC format set when the object was created.
			///
			public DateTime? CreateDate { get; set; }

			///
			///The unique identifier of the entity that caused the event. For example, if the event is "product.created", the entity ID value represents the product code of the product that was created.
			///
			public string EntityId { get; set; }

			///
			///Unique identifier for the event. 
			///
			public string EventId { get; set; }

			///
			///Extended properties. Note: This is purposefully not a CollectionBase type wrapper so consumers start to get used to not having counts returned.
			///
			public List<EventExtendedProperty> ExtendedProperties { get; set; }

			///
			///Unique identifier for the master catalog. 
			///
			public int? MasterCatalogId { get; set; }

			///
			///Unique identifier for the site. This ID is used at all levels of a store, catalog, and tenant to associate objects to a site.
			///
			public int? SiteId { get; set; }

			///
			///Unique identifier of the Mozu tenant.
			///
			public int? TenantId { get; set; }

			///
			///The type of event that was performed, such as "product.created" or "category.deleted".
			///
			public string Topic { get; set; }

		}

}