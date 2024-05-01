using System.ComponentModel.DataAnnotations;
namespace Tololus.Models
{
    public class ComingSoon
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


	}
}
