
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


namespace Mozu.Api.Contracts.ProductRuntime
{
		///
		///	Represents configurable options that a shopper can choose when ordering a product, such as a t-shirt color and size.
		///
		public class ProductOption
		{
			///
			///The fully qualified name of the attribute, which is a user defined attribute identifier.
			///
			public string AttributeFQN { get; set; }

			///
			///If true, the product attribute or option has multiple values.
			///
			public bool? IsMultiValue { get; set; }

			///
			///If true, the entity is required for the request to return a valid response.
			///
			public bool? IsRequired { get; set; }

			///
			///Details of the product option attribute.
			///
			public AttributeDetail AttributeDetail { get; set; }

			///
			///List of possible values for a product option attribute.
			///
			public List<ProductOptionValue> Values { get; set; }

		}

}