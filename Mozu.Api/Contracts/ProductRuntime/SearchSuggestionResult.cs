
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


namespace Mozu.Api.Contracts.ProductRuntime
{
		///
		///	The results of the suggested search terms made to the customer based on queries.
		///
		public class SearchSuggestionResult
		{
			///
			///Text that the shopper types in a search query.
			///
			public string Query { get; set; }

			///
			///List of SearchSuggestionGroups
			///
			public List<SearchSuggestionGroup> SuggestionGroups { get; set; }

		}

}