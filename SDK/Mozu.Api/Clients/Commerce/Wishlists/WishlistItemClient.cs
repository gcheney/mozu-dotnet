
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

namespace Mozu.Api.Clients.Commerce.Wishlists
{
	/// <summary>
	/// Use the Wish List Items subresource to manage items in a shopper wish list. The same product can be defined as an item in any number of wish lists for the customer account. Use the Wish Lists resource to manage shopper wish lists.
	/// </summary>
	public partial class WishlistItemClient 	{
		
		/// <summary>
		/// Retrieves the details of an item in a shopper wish list.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="wishlistId">Unique identifier of the wish list.</param>
		/// <param name="wishlistItemId">Unique identifier of the item to remove from the shopper wish list.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetWishlistItem( wishlistId,  wishlistItemId,  responseFields);
		///   var wishlistItemClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem> GetWishlistItemClient(string wishlistId, string wishlistItemId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Wishlists.WishlistItemUrl.GetWishlistItemUrl(wishlistId, wishlistItemId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves a list of items in a shopper wish list according to any specified filter and sort criteria.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <param name="wishlistId">Unique identifier of the wish list.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItemCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetWishlistItems( wishlistId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		///   var wishlistItemCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItemCollection> GetWishlistItemsClient(string wishlistId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Wishlists.WishlistItemUrl.GetWishlistItemsUrl(wishlistId, startIndex, pageSize, sortBy, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItemCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieve a list of items in a customer wish list by supplying the wish list name.
		/// </summary>
		/// <param name="customerAccountId">The unique identifier of the customer account for which to retrieve wish lists.</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <param name="wishlistName">The name of the wish list to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItemCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetWishlistItemsByWishlistName( customerAccountId,  wishlistName,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		///   var wishlistItemCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItemCollection> GetWishlistItemsByWishlistNameClient(int customerAccountId, string wishlistName, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Wishlists.WishlistItemUrl.GetWishlistItemsByWishlistNameUrl(customerAccountId, wishlistName, startIndex, pageSize, sortBy, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItemCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Adds a product in a site's catalog as an item in a shopper wish list.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="wishlistId">Unique identifier of the wish list.</param>
		/// <param name="wishlistItem">Properties of an item in a shopper wish list.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddItemToWishlist( wishlistItem,  wishlistId,  responseFields);
		///   var wishlistItemClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem> AddItemToWishlistClient(Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem wishlistItem, string wishlistId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Wishlists.WishlistItemUrl.AddItemToWishlistUrl(wishlistId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem>(wishlistItem);
			return mozuClient;

		}

		/// <summary>
		/// Updates the quantity of an item in a shopper wish list.
		/// </summary>
		/// <param name="quantity">The number of cart items in the shopper's active cart.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="wishlistId">Unique identifier of the wish list.</param>
		/// <param name="wishlistItemId">Unique identifier of the item to remove from the shopper wish list.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateWishlistItemQuantity( wishlistId,  wishlistItemId,  quantity,  responseFields);
		///   var wishlistItemClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem> UpdateWishlistItemQuantityClient(string wishlistId, string wishlistItemId, int quantity, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Wishlists.WishlistItemUrl.UpdateWishlistItemQuantityUrl(wishlistId, wishlistItemId, quantity, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Updates the details of an item in a shopper wish list.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="wishlistId">Unique identifier of the wish list.</param>
		/// <param name="wishlistItemId">Unique identifier of the item to remove from the shopper wish list.</param>
		/// <param name="wishlistItem">Properties of an item in a shopper wish list.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateWishlistItem( wishlistItem,  wishlistId,  wishlistItemId,  responseFields);
		///   var wishlistItemClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem> UpdateWishlistItemClient(Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem wishlistItem, string wishlistId, string wishlistItemId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Wishlists.WishlistItemUrl.UpdateWishlistItemUrl(wishlistId, wishlistItemId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistItem>(wishlistItem);
			return mozuClient;

		}

		/// <summary>
		/// Removes all items associated with a shopper wish list.
		/// </summary>
		/// <param name="wishlistId">Unique identifier of the wish list.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=RemoveAllWishlistItems( wishlistId);
		///   var wishlistClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist> RemoveAllWishlistItemsClient(string wishlistId)
		{
			var url = Mozu.Api.Urls.Commerce.Wishlists.WishlistItemUrl.RemoveAllWishlistItemsUrl(wishlistId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Removes an item from the wish list specified in the request.
		/// </summary>
		/// <param name="wishlistId">Unique identifier of the wish list.</param>
		/// <param name="wishlistItemId">Unique identifier of the item to remove from the shopper wish list.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteWishlistItem( wishlistId,  wishlistItemId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteWishlistItemClient(string wishlistId, string wishlistItemId)
		{
			var url = Mozu.Api.Urls.Commerce.Wishlists.WishlistItemUrl.DeleteWishlistItemUrl(wishlistId, wishlistItemId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


