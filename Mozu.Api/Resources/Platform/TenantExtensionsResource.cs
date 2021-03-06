
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

namespace Mozu.Api.Resources.Platform
{
	/// <summary>
	/// Use the Extensions resource to manage Arc.js configuration settings. These are the same settings you can configure through  in the Action Management JSON Editor.
	/// </summary>
	public partial class TenantExtensionsResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public TenantExtensionsResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public TenantExtensionsResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new TenantExtensionsResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves the Arc.js configuration settings for a site.
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.InstalledApplications.TenantExtensions"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantextensions = new TenantExtensions();
		///   var tenantExtensions = tenantextensions.GetExtensions( responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.InstalledApplications.TenantExtensions GetExtensions(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.InstalledApplications.TenantExtensions> response;
			var client = Mozu.Api.Clients.Platform.TenantExtensionsClient.GetExtensionsClient( responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the Arc.js configuration settings for a site.
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.InstalledApplications.TenantExtensions"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantextensions = new TenantExtensions();
		///   var tenantExtensions = await tenantextensions.GetExtensionsAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.InstalledApplications.TenantExtensions> GetExtensionsAsync(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.InstalledApplications.TenantExtensions> response;
			var client = Mozu.Api.Clients.Platform.TenantExtensionsClient.GetExtensionsClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates the Arc.js configuration settings for a site.
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="extensions">The updated details of the Arc.js configuration settings.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.InstalledApplications.TenantExtensions"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantextensions = new TenantExtensions();
		///   var tenantExtensions = tenantextensions.UpdateExtensions( extensions,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.InstalledApplications.TenantExtensions UpdateExtensions(Mozu.Api.Contracts.InstalledApplications.TenantExtensions extensions, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.InstalledApplications.TenantExtensions> response;
			var client = Mozu.Api.Clients.Platform.TenantExtensionsClient.UpdateExtensionsClient( extensions,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates the Arc.js configuration settings for a site.
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="extensions">The updated details of the Arc.js configuration settings.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.InstalledApplications.TenantExtensions"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantextensions = new TenantExtensions();
		///   var tenantExtensions = await tenantextensions.UpdateExtensionsAsync( extensions,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.InstalledApplications.TenantExtensions> UpdateExtensionsAsync(Mozu.Api.Contracts.InstalledApplications.TenantExtensions extensions, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.InstalledApplications.TenantExtensions> response;
			var client = Mozu.Api.Clients.Platform.TenantExtensionsClient.UpdateExtensionsClient( extensions,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}


