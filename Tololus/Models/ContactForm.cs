using System.ComponentModel.DataAnnotations;
namespace Tololus.Models
{
    public class ContactForm
    {
		[Key]
		public int Id { get; set; }

		[Required]
		[MinLength(3, ErrorMessage = "Name must be 3 characters and above!")]
		[MaxLength(30, ErrorMessage = "Name cannot be more than 30 characters!")]
		[RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Only letters are allowed here!")]
		public string Name { get; set; } 

		[Required]
		[StringLength(50, ErrorMessage = "Charcter Limit Exceeded!")]
		[RegularExpression(@"^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9._]+$", ErrorMessage = "Email not correct or contains special character!")]
		public string EmailAddress { get; set; }



		[StringLength(15, ErrorMessage = "Charcter Limit Exceeded!")]
		[RegularExpression(@"^[0-9]+$", ErrorMessage = "PhoneNumber must be a number field or contains special character!")]
		public string PhoneNumber { get; set; }


		[Required(ErrorMessage = "Must select at least one the product category!!")]
		public string Category { get; set; }


		[Required]
		[StringLength(20, ErrorMessage = "Maximum length of 20 characters exceeded!")]
		[MinLength(10, ErrorMessage = "Subject cannot be less than 10 characters!")]
		public string Subject { get; set; }


		[Required]
		[MinLength(10, ErrorMessage = "Minimum of 10 chracters required!")]
		[MaxLength(200, ErrorMessage = "Maximim length of 100 characters required!")]
		public string Message { get; set; }



	}
}
