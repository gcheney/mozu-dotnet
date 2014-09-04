
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

namespace Mozu.Api.Urls.Platform
{
	public partial class TenantUrl 
	{

		/// <summary>
        /// Get Resource Url for GetTenant
        /// </summary>
        /// <param name="responseFields"></param>
        /// <param name="tenantId">Unique identifier of the Mozu tenant.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetTenantUrl(int tenantId, string responseFields =  null)
		{
			var url = "/api/platform/tenants/{tenantId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "tenantId", tenantId);
			return mozuUrl;
		}

								
	}
}

