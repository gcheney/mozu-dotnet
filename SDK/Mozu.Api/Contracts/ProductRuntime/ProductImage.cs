
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.ProductRuntime
{
		///
		///	Properties of an image defined for a product.
		///
		public class ProductImage
		{
			///
			///Descriptive text associated with the image or video that appears on the web storefront. This text displays on a hover-over in the browser, providing further information on the content displayed. The alternate text should be plain alphanumeric text without special characters or HTML coding.
			///
			public string AltText { get; set; }

			///
			///The identifier of the image in the Mozu CMS. Supply a value for either the CMS ID or Image URL parameter.
			///
			public string CmsId { get; set; }

			///
			///The localized title for an image that displays on the storefront. If localized, the displayed content is set per the locale code for the site.
			///
			public string ImageLabel { get; set; }

			///
			///The URL link for the image file associated with a product or category.
			///
			public string ImageUrl { get; set; }

			///
			///Type of media specification required to successfully render the image, video, or other media content for products and categories.
			///
			public string MediaType { get; set; }

			///
			///The numeric order of objects, used by a vocabulary value defined for an extensible attribute, images, and categories.
			///
			public int? Sequence { get; set; }

			///
			///The URL of a video files for a product or category. The path name is set in the language specified by the LocaleCode.
			///
			public string VideoUrl { get; set; }

		}

}