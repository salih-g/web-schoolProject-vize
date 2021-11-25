using System.ComponentModel.DataAnnotations;


namespace Party.Models
{
	public class GuestResponse
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Lütfen isminizi giriniz !")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Lütfen mail adresinizi giriniz !")]
		[EmailAddress]
		public string Email { get; set; }


		[Required(ErrorMessage = "Lütfen telefon numaranızı giriniz !")]
		public string Phone { get; set; }

		[Required(ErrorMessage = "Katılım bilgisini doldurunuz !")]
		public bool? WillAttend { get; set; }
	}
}

