
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
using Mozu.Api.Contracts.CommerceRuntime.Payments;
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.CommerceRuntime.Orders
{
		///
		///	Properties of an order, including its components.
		///
		public class Order
		{
			///
			///The date and time the order was accepted by the tenant.
			///
			public DateTime? AcceptedDate { get; set; }

			///
			///If true, the customer account associated with the order is opted in to receive marketing materials.
			///
			public bool? AcceptsMarketing { get; set; }

			///
			///Properties of an ad-hoc price adjustment for an order.
			///
			public Adjustment Adjustment { get; set; }

			///
			///The amount of the order the shopper can receive in the event of a return. This amount represents the amount captured at the time the order was submitted, not when the order was returned.
			///
			public decimal AmountAvailableForRefund { get; set; }

			///
			///The total amount of the order not currently associated with a payment. The shopper must create one or more payments to satisfy this amount before the order can be fully paid.
			///
			public decimal AmountRemainingForPayment { get; set; }

			///
			///Paged list collection of order attributes.
			///
			public List<OrderAttribute> Attributes { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///The available order, payment, and shipment actions a user can perform for the order.
			///
			public List<string> AvailableActions { get; set; }

			///
			///Container for the customer billing information associated with an order.
			///
			public BillingInfo BillingInfo { get; set; }

			///
			///Date when the order was cancelled. System-supplied and read-only.
			///
			public DateTime? CancelledDate { get; set; }

			///
			///Paged list of notes entered when the order was modified.
			///
			public List<ChangeMessage> ChangeMessages { get; set; }

			///
			///Code that identifies the channel associated with the site where the order was submitted.
			///
			public string ChannelCode { get; set; }

			///
			///Date when the order was closed. Closed order is an order that has been processed and the items shipped. System-supplied and read-only.
			///
			public DateTime? ClosedDate { get; set; }

			///
			///Array list of coupon codes associated with an order submitted using an external system. Mozu populates this list during the order import process.
			///
			public List<string> CouponCodes { get; set; }

			///
			///3-letter ISO 4217 standard global currency code. Currently, only "USD" (US Dollar) is supported.
			///
			public string CurrencyCode { get; set; }

			///
			///Numeric identifer of the customer account.
			///
			public int? CustomerAccountId { get; set; }

			///
			///The type of interaction the shopper used to submit the order. Possible values are Website, Call, Store, or Unknown.
			///
			public string CustomerInteractionType { get; set; }

			///
			///The tax identification number (TIN) of the customer who submitted the order. If the customer who submitted the order has a customer account defined for the tenant, the system sets this value when the order is submitted.
			///
			public string CustomerTaxId { get; set; }

			///
			///Specifies the fulfillment of digital packages associated with this order.
			///
			public List<DigitalPackage> DigitalPackages { get; set; }

			///
			///The aggregate total for all line items in the order, including costs associated with shopper-defined options or extras and any applied discounts.
			///
			public decimal? DiscountedSubtotal { get; set; }

			///
			///The subtotal of the order including any applied discount calculations.
			///
			public decimal? DiscountedTotal { get; set; }

			///
			///Estimated amount of discounts applied to all items in the order, which is system-supplied and read-only.
			///
			public decimal? DiscountTotal { get; set; }

			///
			///The email address of the specified user or the email address associated with the specified entity.
			///
			public string Email { get; set; }

			///
			///The date when the order will no longer be active or considered abandoned. For example, if a guest or anonymous shopper has 14 days of inactivity, the order is considered abandoned after that period of inactivity. An order never expires for shoppers who are logged into their account. Date in UTC Date/Time. System-supplied and read-only.
			///
			public DateTime? ExpirationDate { get; set; }

			///
			///Unique identifier used by an external program to identify a Mozu order.
			///
			public string ExternalId { get; set; }

			///
			///The monetary sum of all fees incurred in the order.
			///
			public decimal? FeeTotal { get; set; }

			///
			///Properties of the item fulfillment information associated with the order. Shoppers can fulfill order items using in-store pickup or direct shipping.
			///
			public FulfillmentInfo FulfillmentInfo { get; set; }

			///
			///The current fulfillment status of the order, which is "Fulfilled," "NotFulfilled," or "PartiallyFulfilled." The order is considered fulfilled when all packages are shipped or all pickups are picked up.
			///
			public string FulfillmentStatus { get; set; }

			///
			///The combined price for all items in the order, including all selected options but excluding any discounts.
			///
			public decimal? HandlingAmount { get; set; }

			public List<AppliedDiscount> HandlingDiscounts { get; set; }

			public decimal? HandlingSubTotal { get; set; }

			///
			///If the handling fee for the order is subject to sales tax, the total tax amount.
			///
			public decimal? HandlingTaxTotal { get; set; }

			///
			///This total represents the handling amount value with any applied discounts.
			///
			public decimal? HandlingTotal { get; set; }

			///
			///If true, the order has a draft that may include one or more uncommitted changes to the order or its components.
			///
			public bool? HasDraft { get; set; }

			///
			///Unique identifier of the order.
			///
			public string Id { get; set; }

			///
			///If the order was imported from an external program, the date and time the order was imported into Mozu.
			///
			public DateTime? ImportDate { get; set; }

			///
			///List of invalid coupon codes the shopper entered for the order.
			///
			public List<InvalidCoupon> InvalidCoupons { get; set; }

			///
			///The IP address from which the order originated.
			///
			public string IpAddress { get; set; }

			///
			///If true, this version of the order is a draft that might contain uncommitted changes.
			///
			public bool? IsDraft { get; set; }

			///
			///If true, the shopper can return any of the items in this order to the tenant.
			///
			public bool IsEligibleForReturns { get; set; }

			///
			///If true, this order was submitted using an external system, and the order record was imported into Mozu.
			///
			public bool? IsImport { get; set; }

			///
			///If true, the order is exempt from applied sales tax.
			///
			public bool? IsTaxExempt { get; set; }

			///
			///An array list of objects in the returned collection.
			///
			public List<OrderItem> Items { get; set; }

			///
			///The total amount of tax applied to items in the order.
			///
			public decimal? ItemTaxTotal { get; set; }

			///
			///The date when the order was last validated against the product catalog. Date in UTC Date/Time. System-supplied and read-only.
			///
			public DateTime? LastValidationDate { get; set; }

			///
			///The unique code that identifies the location where the order was submitted.
			///
			public string LocationCode { get; set; }

			///
			///Paged list collection of order notes.
			///
			public List<OrderNote> Notes { get; set; }

			///
			///List of order-level discounts that apply to the order.
			///
			public List<AppliedDiscount> OrderDiscounts { get; set; }

			///
			///The order number that displays on the storefront which differs from the order ID.
			///
			public int? OrderNumber { get; set; }

			///
			///Identifier of the cart prior to the customer proceeding to checkout.
			///
			public string OriginalCartId { get; set; }

			///
			///Array list of physical packages shipped for the specified order.
			///
			public List<Package> Packages { get; set; }

			public string ParentOrderId { get; set; }

			///
			///If this order was created to fulfill an item replacement as part of a return merchandise authorization (RMA), the unique identifier of the return.
			///
			public string ParentReturnId { get; set; }

			///
			///Wrapper for a collection of payments associated with this order. An order can include any number of payments.
			///
			public List<Payment> Payments { get; set; }

			///
			///Status of the payment for the specified order.
			///
			public string PaymentStatus { get; set; }

			///
			///Array list of the in-store pickups defined for the order.
			///
			public List<Pickup> Pickups { get; set; }

			///
			///Status of any returns associated with this order after it was completed.
			///
			public string ReturnStatus { get; set; }

			///
			///Array list of the shipments defined to fulfill items in this order using the direct ship fulfillment method.
			///
			public List<Shipment> Shipments { get; set; }

			///
			///Properties of an ad-hoc price adjustment made for an order.
			///
			public Adjustment ShippingAdjustment { get; set; }

			///
			///List of shipping discounts to apply to the order.
			///
			public List<ShippingDiscount> ShippingDiscounts { get; set; }

			///
			///The shipping subtotal amount calculated without any applied discounts.
			///
			public decimal? ShippingSubTotal { get; set; }

			///
			///The total amount of sales tax incurred for shipping charges on the order.
			///
			public decimal? ShippingTaxTotal { get; set; }

			///
			///Amount of the shipping fees for the order.
			///
			public decimal? ShippingTotal { get; set; }

			///
			///A paged list collection of shopper notes for the order.
			///
			public ShopperNotes ShopperNotes { get; set; }

			///
			///Unique identifier of the site.
			///
			public int? SiteId { get; set; }

			///
			///The device from which the order originated in the case of offline orders.
			///
			public string SourceDevice { get; set; }

			///
			///The current status of this order. Possible values are "Pending", "Submitted", "Processing", "Pending Review", "Closed", or "Cancelled". System-supplied and read-only.
			///
			public string Status { get; set; }

			///
			///The date and time the order was submitted. System-supplied and read-only.
			///
			public DateTime? SubmittedDate { get; set; }

			///
			///Amount of the order without sales tax, shipping costs, and other fees.
			///
			public decimal? Subtotal { get; set; }

			///
			///The total monetary sum of sales tax for the order.
			///
			public decimal? TaxTotal { get; set; }

			///
			///Unique identifier of the Mozu tenant.
			///
			public int? TenantId { get; set; }

			///
			///Amount of the order, including items, sales tax, shipping costs, and other fees.
			///
			public decimal? Total { get; set; }

			///
			///The total amount collected to date for the order.
			///
			public decimal TotalCollected { get; set; }

			///
			///This specifies the order type. This means, was this order placed online or offline? Online means shopper created the order at checkout, offline means the order was a phone order.
			///
			public string Type { get; set; }

			///
			///Response returned by an order validation capability application.
			///
			public List<OrderValidationResult> ValidationResults { get; set; }

			///
			///The current version number of the order.
			///
			public string Version { get; set; }

			///
			///Unique identifier of the customer visit in which the order was created or last updated.
			///
			public string VisitId { get; set; }

			///
			///Unique identifier of the web session in which the order was created or last updated.
			///
			public string WebSessionId { get; set; }

		}

}