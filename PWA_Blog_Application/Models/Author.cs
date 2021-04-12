using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PWA_Blog_Application.Models
{
	public class Author
	{
		[Key]
		public int AuthorId { get; set; }

		[Display(Name = "First Name")]
		[Required]
		public string Author_FirstName { get; set; }

		[Display(Name = "Last Name")]
		[Required]
		public string Author_LastName { get; set; }

		[Display(Name = "Email")]
		[EmailAddress]
		[Required(ErrorMessage = "Please provide an Email address.")]
		public string Email { get; set; }

		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Display(Name = "BirthDate")]
		public DateTime BirthDate { get; set; }

		[Display(Name = "Phone Number")]
		[Phone]
		public string PhoneNumber { get; set; }

		[Display(Name = "Website")]
		public string Website { get; set; }

		[Display(Name = "Country")]
		public string Country { get; set; }

		[Display(Name = "Province")]
		public string Province { get; set; }

		[Display(Name = "Postal Code")]
		public string Postalcode { get; set; }
	}
}
