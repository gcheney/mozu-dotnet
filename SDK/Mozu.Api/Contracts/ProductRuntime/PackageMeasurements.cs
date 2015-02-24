
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.ProductRuntime
{
		///
		///	Dimensions of the packaged product.
		///
		public class PackageMeasurements
		{
			///
			///Height of a package or bundle package in imperial units of feet and inches.
			///
			public Measurement PackageHeight { get; set; }

			///
			///Length of a package or bundle package in imperial units of feet and inches.
			///
			public Measurement PackageLength { get; set; }

			///
			///Weight of a package or bundle package in imperial units of pounds and ounces.
			///
			public Measurement PackageWeight { get; set; }

			///
			///Width of a package or bundle package in imperial units of feet and inches.
			///
			public Measurement PackageWidth { get; set; }

		}

}