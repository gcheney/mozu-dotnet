
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.Event
{
		///
		///	Properties for the HTTP status for an event.
		///
		public class HttpStatus
		{
			///
			///The higher-level integer based HTTP Status Code returned by the remote endpoint
			///
			public int Code { get; set; }

			///
			///The display name of the source product property. For a product field it will be the display name of the field. For a product attribute it will be the Attribute Name.
			///
			public string Name { get; set; }

		}

}