
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.CommerceRuntime.Commerce
{
		///
		///	Properties of a system message displayed when a change, such as a change in product price, occurs for a cart or order.
		///
		public class ChangeMessage
		{
			///
			///The order or item amount changed, if applicable.
			///
			public decimal? Amount { get; set; }

			///
			///Unique identifier of an app available in your Mozu tenant or within Mozu Dev Center. This ID is unique across all apps installed, initialized, and enabled in the Mozu Admin and those in development through the Dev Center Console.
			///
			public string AppId { get; set; }

			///
			///App Key
			///
			public string AppKey { get; set; }

			///
			///App Name
			///
			public string AppName { get; set; }

			///
			///The unique identifier of the API request associated with the event action, which might contain multiple actions.
			///
			public string CorrelationId { get; set; }

			///
			///Date and time when the entity was created, represented in UTC Date/Time.
			///
			public DateTime? CreateDate { get; set; }

			///
			///Unique identifier of the source product property. For a product field it will be the name of the field. For a product attribute it will be the Attribute FQN. 
			///
			public string Id { get; set; }

			///
			///Identifier for the object associated with the change message, which can represent a cart, cart item, or an order.
			///
			public string Identifier { get; set; }

			///
			///The text of the change message, such as "This product is no longer available." System-supplied and read-only.
			///
			public string Message { get; set; }

			///
			///Metadata content for entities, used by document lists, document type lists, document type, views, entity lists, and list views.
			///
			public object Metadata { get; set; }

			///
			///The new value of the object affected by the change, such as the new price of the product. System-supplied and read-only.
			///
			public string NewValue { get; set; }

			///
			///The prior value of the object affected by the change, such as the price of the product when it was added to the cart. System-supplied and read-only.
			///
			public string OldValue { get; set; }

			///
			///The text that appears on the subject line of the message, such as "The product price has changed."
			///
			public string Subject { get; set; }

			///
			///Represents the type of object affected by the change, such as Cart Item or Product. System-supplied and read-only.
			///
			public string SubjectType { get; set; }

			///
			///If true, the change associated with the message executed successfully.
			///
			public bool? Success { get; set; }

			///
			///User First Name
			///
			public string UserFirstName { get; set; }

			///
			///Unique identifier of the customer account (shopper or system user). System-supplied and read-only. If the shopper user is anonymous, the user ID represents a system-generated user ID string.
			///
			public string UserId { get; set; }

			///
			///User Last Name
			///
			public string UserLastName { get; set; }

			///
			///User Type (e.g. Shopper, Admin, etc.)
			///
			public string UserScopeType { get; set; }

			///
			///The action associated with this message. For example, if the price of a product changes, the verb could be "Increased" or "Decreased". If the product is no longer available, the verb could be "Invalidated". System-supplied and read-only.
			///
			public string Verb { get; set; }

		}

}