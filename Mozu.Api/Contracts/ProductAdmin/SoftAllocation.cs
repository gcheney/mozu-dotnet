
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	Mozu.ProductAdmin.Contracts.SoftAllocation ApiType DOCUMENT_HERE 
		///
		public class SoftAllocation
		{
			///
			///Basic audit info about the object, including date, time, and user account. This data may be captured when creating, updating, and removing data.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///The date and time in UTC format that the soft allocation expires.
			///
			public DateTime? ExpiresAt { get; set; }

			///
			///Unique identifier of the source property, such as a catalog, discount, order, or email template.For a product field it will be the name of the field.For a category ID, must be a positive integer not greater than 2000000. By default,  auto-generates a category ID when categories are created. If you want to specify an ID during creation (which preserves category link relationships when migrating tenant data from one sandbox to another), you must also include the  query string in the endpoint. For example, . Then, use the  property to specify the desired category ID.For a product attribute it will be the Attribute FQN.For a document, the ID must be specified as a 32 character, case-insensitive, alphanumeric string. You can specify the ID as 32 sequential characters or as groups separated by dashes in the format 8-4-4-4-12. For example, or.For email templates, the ID must be one of the following values:			
			///
			public int? Id { get; set; }

			///
			///The unique, user-defined code that identifies a location. This location can be the location where the order was entered, location for newly in-stock products, and where products are returned.
			///
			public string LocationCode { get; set; }

			///
			///The unique, user-defined product code of a product, used throughout  to reference and associate to a product.
			///
			public string ProductCode { get; set; }

			///
			///The specified quantity of objects and items. This property is used for numerous object types including products, options, components within a product bundle, cart and order items, returned items, shipping line items, items in a digital product. and items associated with types and reservations.
			///
			public int? Quantity { get; set; }

			///
			///Entity RefrenceID this allocation is linked to.
			///
			public string ReferenceId { get; set; }

			///
			///item Id of the RefrenceID.
			///
			public string ReferenceItemId { get; set; }

		}

}