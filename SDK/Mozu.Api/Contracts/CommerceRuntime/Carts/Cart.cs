
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

using Mozu.Api.Contracts.CommerceRuntime.Commerce;
using Mozu.Api.Contracts.CommerceRuntime.Discounts;
using Mozu.Api.Contracts.CommerceRuntime.Fulfillment;
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.CommerceRuntime.Carts
{
		///
		///	Properties of a shopping cart.
		///
		public class Cart
		{
			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///Collection (list or paged) of change messages logged for each modification made by a shopper to their carts, wishlists, orders, package, payment, pickup, and returns. Change log messages are system-supplied based on shopper actions and read only.
			///
			public List<ChangeMessage> ChangeMessages { get; set; }

			///
			///Code that identifies the channel associated with the site for the shopper's created shopping cart, order, and return.
			///
			public string ChannelCode { get; set; }

			///
			///Array list of coupon codes associated with a shopping cart and the associated order. These codes are entered by a shopper when proceeding to checkout. 
			///
			public List<string> CouponCodes { get; set; }

			///
			///3-letter ISO 4217 standard global currency code. Currently, only "USD" (US Dollar) is supported.
			///
			public string CurrencyCode { get; set; }

			///
			///The type of customer interaction used to create this shopping cart. Possible values are Website, Call, Store, or Unknown.
			///
			public string CustomerInteractionType { get; set; }

			///
			///The aggregate total for all items in the cart, including costs associated with shopper-defined options or extras and any applied discounts.
			///
			public decimal? DiscountedSubtotal { get; set; }

			///
			///The subtotal of the cart, order, and wishlist items, including any applied discount calculations. Wishlist subtotals may change depending on the length of time, available discounts, and stock amounts of products at the time of review by shoppers.
			///
			public decimal? DiscountedTotal { get; set; }

			///
			///Estimated amount of discounts applied to all items in the carts and orders. System-supplied and read-only. This value will be available at the wish list, cart item, order item, and wish list item level at a later time.
			///
			public decimal? DiscountTotal { get; set; }

			///
			///Date and time in UTC format when a discount, credit, wish list, or cart expires. An expired discount no longer can be redeemed. An expired wish list is no longer available. An expired credit can no longer be redeemed for a purchase. Acart becomes inactive and expired based on a system-calculated interval. For example, if an anonymous shopper has 14 days of inactivity, the cart is considered abandoned after that period of inactivity. System-supplied and read-only.
			///
			public DateTime? ExpirationDate { get; set; }

			///
			///The monetary sum of all fees incurred in the cart, order, line item in a cart, or line item in an order. This value is not calculated for wish lists at this time.
			///
			public decimal? FeeTotal { get; set; }

			///
			///Properties of the information required to fulfill the cart, order, or wish list. Shoppers can fulfill ordered items by using in-store pickup or direct shipping.
			///
			public FulfillmentInfo FulfillmentInfo { get; set; }

			///
			///Calculated total tax amount for handling costs if the cart/order is subject to sales tax. 
			///
			public decimal? HandlingTaxTotal { get; set; }

			///
			///Unique identifier of the source product property. For a product field it will be the name of the field. For a product attribute it will be the Attribute FQN. 
			///
			public string Id { get; set; }

			///
			///The list of invalid coupons the shopper attempted to enter for the cart or order. These coupons may no longer be valid or incorrectly entered.
			///
			public List<InvalidCoupon> InvalidCoupons { get; set; }

			///
			///An array list of objects in the returned collection.
			///
			public List<CartItem> Items { get; set; }

			///
			///The total amount of calculated tax for items, used by carts, orders, and wish lists.
			///
			public decimal? ItemTaxTotal { get; set; }

			///
			///The date in UTC Date/Time when the items in the cart were last validated against the site's product catalog. System-supplied and read-only.
			///
			public DateTime? LastValidationDate { get; set; }

			///
			///List of order-level discounts projected to apply to the cart at checkout or order.
			///
			public List<AppliedDiscount> OrderDiscounts { get; set; }

			///
			///The shipping subtotal amount calculated without any applied discounts for line item and entire amounts of carts and orders. This property is not calculated for wish lists at this time.
			///
			public decimal? ShippingSubTotal { get; set; }

			///
			///The total amount of tax incurred on the shipping charges in the cart and order. This property is not calculated at this time for wish lists.
			///
			public decimal? ShippingTaxTotal { get; set; }

			///
			///The calculated total shipping amount estimated for carts or orders, including tax. This amount is not calculated for wish lists at this time.
			///
			public decimal? ShippingTotal { get; set; }

			///
			///Unique identifier of the site.
			///
			public int? SiteId { get; set; }

			///
			///Estimated amount of the cart or order without sales tax, shipping costs, and other fees. This amount is not calculated for wish lists at this time.
			///
			public decimal? Subtotal { get; set; }

			///
			///The total monetary sum of sales tax estimated for a cart or order.
			///
			public decimal? TaxTotal { get; set; }

			///
			///Unique identifier of the Mozu tenant.
			///
			public int? TenantId { get; set; }

			///
			///Total is used to indicate the monetary, estimated total amount of the cart or order, including items, sales tax, shipping costs, and other fees. Totals are not estimated for wish lists at this time.
			///
			public decimal? Total { get; set; }

			///
			///Unique identifier of the customer account (shopper or system user). System-supplied and read-only. If the shopper user is anonymous, the user ID represents a system-generated user ID string.
			///
			public string UserId { get; set; }

			///
			///Unique identifier of the customer visit in which the cart was created or last modified.
			///
			public string VisitId { get; set; }

			///
			///Unique identifier of the web session in which the cart, order, return, or wish list was created or last modified.
			///
			public string WebSessionId { get; set; }

		}

}