
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

namespace Mozu.Api.Resources.Commerce.Orders
{
	/// <summary>
	/// Use this subresource to retrieve details about items in an active order.
	/// </summary>
	public partial class OrderItemResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public OrderItemResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public OrderItemResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new OrderItemResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves the details of a single order item.
		/// </summary>
		/// <param name="draft">If true, retrieve the draft version of this order item, which might include uncommitted changes to the order item, the order, or other order components.</param>
		/// <param name="orderId">Unique identifier of the order item to retrieve.</param>
		/// <param name="orderItemId">Unique identifier of the order item details to retrieve.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var orderItem = orderitem.GetOrderItem( orderId,  orderItemId,  draft,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem GetOrderItem(string orderId, string orderItemId, bool? draft =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.GetOrderItemClient( orderId,  orderItemId,  draft,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem> GetOrderItemAsync(string orderId, string orderItemId, bool? draft =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.GetOrderItemClient( orderId,  orderItemId,  draft,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of all items in an order.
		/// </summary>
		/// <param name="draft">If true, retrieve the draft version of the order's items, which might include uncommitted changes to one or more order items, the order itself, or other order components.</param>
		/// <param name="orderId">Unique identifier of the order items to retrieve.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItemCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var orderItemCollection = orderitem.GetOrderItems( orderId,  draft,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItemCollection GetOrderItems(string orderId, bool? draft =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItemCollection> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.GetOrderItemsClient( orderId,  draft,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItemCollection> GetOrderItemsAsync(string orderId, bool? draft =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItemCollection> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.GetOrderItemsClient( orderId,  draft,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Adds a new item to a defined order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order for which to add the item.</param>
		/// <param name="responseFields"></param>
		/// <param name="skipInventoryCheck">If true, do not validate the product inventory when adding this item to the order.</param>
		/// <param name="updateMode">Specifies whether to add the item by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal," "ApplyToDraft," or "ApplyAndCommit."</param>
		/// <param name="version">System-supplied integer that represents the current version of the order, which prevents users from unintentionally overriding changes to the order. When a user performs an operation for a defined order, the system validates that the version of the updated order matches the version of the order on the server. After the operation completes successfully, the system increments the version number by one.</param>
		/// <param name="orderItem">The properties of the item to create in the existing order.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var order = orderitem.CreateOrderItem( orderItem,  orderId,  updateMode,  version,  skipInventoryCheck,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order CreateOrderItem(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem orderItem, string orderId, string updateMode =  null, string version =  null, bool? skipInventoryCheck =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.CreateOrderItemClient( orderItem,  orderId,  updateMode,  version,  skipInventoryCheck,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> CreateOrderItemAsync(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem orderItem, string orderId, string updateMode =  null, string version =  null, bool? skipInventoryCheck =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.CreateOrderItemClient( orderItem,  orderId,  updateMode,  version,  skipInventoryCheck,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Update the discount applied to an item in an order.
		/// </summary>
		/// <param name="discountId">Unique identifier of the discount. System-supplied and read only.</param>
		/// <param name="orderId">Unique identifier of the order associated with the item discount.</param>
		/// <param name="orderItemId">Unique identifier of the item in the order.</param>
		/// <param name="responseFields"></param>
		/// <param name="updateMode">Specifies whether to change the item discount by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal," "ApplyToDraft," or "ApplyAndCommit."</param>
		/// <param name="version">System-supplied integer that represents the current version of the order, which prevents users from unintentionally overriding changes to the order. When a user performs an operation for a defined order, the system validates that the version of the updated order matches the version of the order on the server. After the operation completes successfully, the system increments the version number by one.</param>
		/// <param name="discount">Properties of the discount to modify for the order item.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var order = orderitem.UpdateOrderItemDiscount( discount,  orderId,  orderItemId,  discountId,  updateMode,  version,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateOrderItemDiscount(Mozu.Api.Contracts.CommerceRuntime.Discounts.AppliedDiscount discount, string orderId, string orderItemId, int discountId, string updateMode =  null, string version =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.UpdateOrderItemDiscountClient( discount,  orderId,  orderItemId,  discountId,  updateMode,  version,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> UpdateOrderItemDiscountAsync(Mozu.Api.Contracts.CommerceRuntime.Discounts.AppliedDiscount discount, string orderId, string orderItemId, int discountId, string updateMode =  null, string version =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.UpdateOrderItemDiscountClient( discount,  orderId,  orderItemId,  discountId,  updateMode,  version,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates the item fulfillment information for the order specified in the request.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="orderItemId">Unique identifier of the item in the order.</param>
		/// <param name="responseFields"></param>
		/// <param name="updateMode">Specifies whether to apply the coupon by updating the original order, updating the order in draft mode, or updating the order in draft mode and then commit the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal," "ApplyToDraft," or "ApplyAndCommit."</param>
		/// <param name="version">System-supplied integer that represents the current version of the order, which prevents users from unintentionally overriding changes to the order. When a user performs an operation for a defined order, the system validates that the version of the updated order matches the version of the order on the server. After the operation completes successfully, the system increments the version number by one.</param>
		/// <param name="orderItem">Properties of the order item to update for fulfillment.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var order = orderitem.UpdateItemFulfillment( orderItem,  orderId,  orderItemId,  updateMode,  version,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateItemFulfillment(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem orderItem, string orderId, string orderItemId, string updateMode =  null, string version =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.UpdateItemFulfillmentClient( orderItem,  orderId,  orderItemId,  updateMode,  version,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> UpdateItemFulfillmentAsync(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem orderItem, string orderId, string orderItemId, string updateMode =  null, string version =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.UpdateItemFulfillmentClient( orderItem,  orderId,  orderItemId,  updateMode,  version,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Override the price of an individual product on a line item in the specified order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order containing the item to price override.</param>
		/// <param name="orderItemId">Unique identifier of the item in the order to price override.</param>
		/// <param name="price">The override price to specify for this item in the specified order.</param>
		/// <param name="responseFields"></param>
		/// <param name="updateMode">Specifies whether to change the product price by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal," "ApplyToDraft," or "ApplyAndCommit."</param>
		/// <param name="version">System-supplied integer that represents the current version of the order, which prevents users from unintentionally overriding changes to the order. When a user performs an operation for a defined order, the system validates that the version of the updated order matches the version of the order on the server. After the operation completes successfully, the system increments the version number by one.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var order = orderitem.UpdateItemProductPrice( orderId,  orderItemId,  price,  updateMode,  version,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateItemProductPrice(string orderId, string orderItemId, decimal price, string updateMode =  null, string version =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.UpdateItemProductPriceClient( orderId,  orderItemId,  price,  updateMode,  version,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> UpdateItemProductPriceAsync(string orderId, string orderItemId, decimal price, string updateMode =  null, string version =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.UpdateItemProductPriceClient( orderId,  orderItemId,  price,  updateMode,  version,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Update the quantity of an item in an order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order containing the item to update quantity.</param>
		/// <param name="orderItemId">Unique identifier of the item in the order to update quantity.</param>
		/// <param name="quantity">The quantity of the item in the order to update.</param>
		/// <param name="responseFields"></param>
		/// <param name="updateMode">Specifies whether to change the item quantity by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal," "ApplyToDraft," or "ApplyAndCommit."</param>
		/// <param name="version">System-supplied integer that represents the current version of the order, which prevents users from unintentionally overriding changes to the order. When a user performs an operation for a defined order, the system validates that the version of the updated order matches the version of the order on the server. After the operation completes successfully, the system increments the version number by one.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var order = orderitem.UpdateItemQuantity( orderId,  orderItemId,  quantity,  updateMode,  version,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateItemQuantity(string orderId, string orderItemId, int quantity, string updateMode =  null, string version =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.UpdateItemQuantityClient( orderId,  orderItemId,  quantity,  updateMode,  version,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> UpdateItemQuantityAsync(string orderId, string orderItemId, int quantity, string updateMode =  null, string version =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.UpdateItemQuantityClient( orderId,  orderItemId,  quantity,  updateMode,  version,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Removes a previously added item from a defined order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order with the item to remove.</param>
		/// <param name="orderItemId">Unique identifier of the item to remove from the order.</param>
		/// <param name="updateMode">Specifies whether to remove the item by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal," "ApplyToDraft," or "ApplyAndCommit."</param>
		/// <param name="version">System-supplied integer that represents the current version of the order, which prevents users from unintentionally overriding changes to the order. When a user performs an operation for a defined order, the system validates that the version of the updated order matches the version of the order on the server. After the operation completes successfully, the system increments the version number by one.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var order = orderitem.DeleteOrderItem( orderId,  orderItemId,  updateMode,  version);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order DeleteOrderItem(string orderId, string orderItemId, string updateMode =  null, string version =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.DeleteOrderItemClient( orderId,  orderItemId,  updateMode,  version);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> DeleteOrderItemAsync(string orderId, string orderItemId, string updateMode =  null, string version =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.DeleteOrderItemClient( orderId,  orderItemId,  updateMode,  version);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


