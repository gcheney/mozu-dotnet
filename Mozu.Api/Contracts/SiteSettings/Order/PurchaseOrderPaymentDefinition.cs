
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


namespace Mozu.Api.Contracts.SiteSettings.Order
{
		public class PurchaseOrderPaymentDefinition
		{
			public bool AllowSplitPayment { get; set; }

			public bool IsEnabled { get; set; }

			public List<PurchaseOrderMemoField> MemoFields { get; set; }

			public List<PurchaseOrderNetTerm> NetTerms { get; set; }

		}

}