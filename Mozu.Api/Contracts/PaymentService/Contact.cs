
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.PaymentService
{
		///
		///	Contact information for an account.
		///
		public class Contact
		{
			///
			///Mozu.PaymentService.Contracts.Contact country ApiTypeMember DOCUMENT_HERE 
			///
			public string Country { get; set; }

			///
			///The email address for the customer account and contact. This email may be used for login to the storefront, receiving in-stock product notifications, and subscription mailing lists.
			///
			public string Email { get; set; }

			///
			///The full first name of a customer or contact name.
			///
			public string Firstname { get; set; }

			///
			///The full last name of a customer or contact name.
			///
			public string Lastname { get; set; }

			///
			///The associated contact's phone number.
			///
			public string Phone { get; set; }

		}

}