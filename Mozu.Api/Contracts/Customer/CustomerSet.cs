
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

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.Customer
{
		///
		///	The details of the customer set.
		///
		public class CustomerSet
		{
			///
			///A collection of aggregate information about the customer set, including the amount of sites and customers assocaited with the customer set.
			///
			public CustomerSetAggregateInfo AggregateInfo { get; set; }

			///
			///Basic audit info about the object, including date, time, and user account. This data may be captured when creating, updating, and removing data.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///The unique identifier of the customer set.
			///
			public string Code { get; set; }

			///
			///The localized description in text for the object, displayed per the locale code. For example, descriptions are used for product descriptions, attributes, and pre-authorization transaction types.
			///
			public string Description { get; set; }

			///
			///Indicates if the object is default. This indicator is used for product variations and site search settings. If true, the value/object is the default option.
			///
			public bool IsDefault { get; set; }

			///
			///The user supplied name that appears in . You can use this field for identification purposes.
			///
			public string Name { get; set; }

			///
			///Collection of sites associated with the tenant.
			///
			public List<CustomerSetSite> Sites { get; set; }

		}

}