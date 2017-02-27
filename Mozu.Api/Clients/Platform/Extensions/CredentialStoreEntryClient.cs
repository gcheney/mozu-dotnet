
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
using Mozu.Api.Security;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Mozu.Api.Clients.Platform.Extensions
{
	/// <summary>
	/// 
	/// </summary>
	public partial class CredentialStoreEntryClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="credentials"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=StoreCredentials( credentials);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient StoreCredentialsClient(Mozu.Api.Contracts.InstalledApplications.CredentialStoreEntry credentials)
		{
			var url = Mozu.Api.Urls.Platform.Extensions.CredentialStoreEntryUrl.StoreCredentialsUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.InstalledApplications.CredentialStoreEntry>(credentials);
			return mozuClient;

		}


	}

}

