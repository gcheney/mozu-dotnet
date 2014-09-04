
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

namespace Mozu.Api.Clients.Content
{
	/// <summary>
	/// Use the Document Types resource to view the document types supplied by the Content API.
	/// </summary>
	public partial class DocumentTypeClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.DocumentTypeCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetDocumentTypes(dataViewMode,  pageSize,  startIndex,  responseFields);
		///   var documentTypeCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.DocumentTypeCollection> GetDocumentTypesClient(DataViewMode dataViewMode, int? pageSize =  null, int? startIndex =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Content.DocumentTypeUrl.GetDocumentTypesUrl(pageSize, startIndex, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.DocumentTypeCollection>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="documentTypeName"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.DocumentType"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetDocumentType(dataViewMode,  documentTypeName,  responseFields);
		///   var documentTypeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.DocumentType> GetDocumentTypeClient(DataViewMode dataViewMode, string documentTypeName, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Content.DocumentTypeUrl.GetDocumentTypeUrl(documentTypeName, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.DocumentType>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="documentType"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.DocumentType"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateDocumentType(dataViewMode,  documentType,  responseFields);
		///   var documentTypeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.DocumentType> CreateDocumentTypeClient(DataViewMode dataViewMode, Mozu.Api.Contracts.Content.DocumentType documentType, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Content.DocumentTypeUrl.CreateDocumentTypeUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.DocumentType>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Content.DocumentType>(documentType)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="documentTypeName"></param>
		/// <param name="responseFields"></param>
		/// <param name="documentType"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.DocumentType"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateDocumentType( documentType,  documentTypeName,  responseFields);
		///   var documentTypeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.DocumentType> UpdateDocumentTypeClient(Mozu.Api.Contracts.Content.DocumentType documentType, string documentTypeName, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Content.DocumentTypeUrl.UpdateDocumentTypeUrl(documentTypeName, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.DocumentType>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Content.DocumentType>(documentType);
			return mozuClient;

		}


	}

}


