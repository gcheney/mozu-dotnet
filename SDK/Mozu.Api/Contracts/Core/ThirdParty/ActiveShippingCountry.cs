
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


namespace Mozu.Api.Contracts.Core.ThirdParty
{
		///
		///	Properties of a shipping country active for a third-party capability.
		///
		public class ActiveShippingCountry
		{
			///
			///Array list of the active shipping carriers for the country.
			///
			public List<string> ActiveCarriers { get; set; }

			public string CountryCode { get; set; }

		}

}