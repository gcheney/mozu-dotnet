
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.Core.Extensible
{
		///
		///	Validates the attribute configured for the customer in the storefront against the attribute configured in Mozu admin.
		///
		public class AttributeValidation
		{
			///
			///The latest possible date and time the extensible attribute can be validated.
			///
			public DateTime? MaxDateTime { get; set; }

			///
			///The maximum number that can be entered as a value for an extensible attribute.
			///
			public decimal? MaxNumericValue { get; set; }

			///
			///The maximum character length possible for a string value entered for an extensible attribute.
			///
			public int? MaxStringLength { get; set; }

			///
			///The earliest date and time an extensible attribute can be validated.
			///
			public DateTime? MinDateTime { get; set; }

			///
			///The minimum numeric value required to validate an extensible attribute.
			///
			public decimal? MinNumericValue { get; set; }

			///
			///The minimum character length possible for a string value entered for an extensible attribute.
			///
			public int? MinStringLength { get; set; }

			///
			///Regular expression used to process and validate an extensible attribute value that require special formatting, such as phone numbers.
			///
			public string RegularExpression { get; set; }

		}

}