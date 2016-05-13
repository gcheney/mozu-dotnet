
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Commerce.Shipping.Admin.Profiles
{
	public partial class ShippingInclusionRuleUrl 
	{

		/// <summary>
        /// Get Resource Url for GetShippingInclusionRule
        /// </summary>
        /// <param name="id"></param>
        /// <param name="profilecode"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetShippingInclusionRuleUrl(string profilecode, string id, string responseFields =  null)
		{
			var url = "/api/commerce/shipping/admin/profiles/{profilecode}/rules/shippinginclusions/{id}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "id", id);
			mozuUrl.FormatUrl( "profilecode", profilecode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetShippingInclusionRules
        /// </summary>
        /// <param name="profilecode"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetShippingInclusionRulesUrl(string profilecode, string responseFields =  null)
		{
			var url = "/api/commerce/shipping/admin/profiles/{profilecode}/rules/shippinginclusions?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "profilecode", profilecode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for CreateShippingInclusionRule
        /// </summary>
        /// <param name="profilecode"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateShippingInclusionRuleUrl(string profilecode, string responseFields =  null)
		{
			var url = "/api/commerce/shipping/admin/profiles/{profilecode}/rules/shippinginclusions?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "profilecode", profilecode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateShippingInclusionRule
        /// </summary>
        /// <param name="id"></param>
        /// <param name="profilecode"></param>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateShippingInclusionRuleUrl(string profilecode, string id, string responseFields =  null)
		{
			var url = "/api/commerce/shipping/admin/profiles/{profilecode}/rules/shippinginclusions/{id}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "id", id);
			mozuUrl.FormatUrl( "profilecode", profilecode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteShippingInclusionRule
        /// </summary>
        /// <param name="id"></param>
        /// <param name="profilecode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteShippingInclusionRuleUrl(string profilecode, string id)
		{
			var url = "/api/commerce/shipping/admin/profiles/{profilecode}/rules/shippinginclusions/{id}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "id", id);
			mozuUrl.FormatUrl( "profilecode", profilecode);
			return mozuUrl;
		}

		
	}
}
