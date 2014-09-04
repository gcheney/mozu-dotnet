
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.Customer
{
		///
		///	Properties of an authentication ticket generated for a customer account.
		///
		public class CustomerAuthTicket
		{
			///
			///Access token string that enables authentication for the customer account.
			///
			public string AccessToken { get; set; }

			///
			///The date and time the access token expires.
			///
			public DateTime AccessTokenExpiration { get; set; }

			///
			///Refresh token string used to generate a new access token after expiration for a customer account authentication ticket.
			///
			public string RefreshToken { get; set; }

			///
			///The date and time the refresh token expires.
			///
			public DateTime RefreshTokenExpiration { get; set; }

			///
			///User ID associated with the customer account authentication ticket.
			///
			public string UserId { get; set; }

			///
			///Properties of the customer account associated with the authentication ticket.
			///
			public CustomerAccount CustomerAccount { get; set; }

		}

}