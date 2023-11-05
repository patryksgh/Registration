using System.ComponentModel.DataAnnotations;

namespace Registration.Models
{
    public class Data
    {
        [Required(ErrorMessage = "Imię jest wymagane.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Imię musi mieć co najmniej 2 znaki.")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Nazwisko jest wymagane.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Nazwisko musi mieć co najmniej 2 znaki.")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Adres e-mail jest wymagany.")]
        [EmailAddress(ErrorMessage = "Wprowadź poprawny adres e-mail.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Hasło jest wymagane.")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Hasło musi mieć co najmniej 8 znaków.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "Hasło musi zawierać co najmniej jedną dużą literę, jedną małą literę i jedną cyfrę.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Potwierdzenie hasła jest wymagane.")]
        [Compare("Password", ErrorMessage = "Hasło i jego potwierdzenie nie pasują do siebie.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Numer telefonu jest wymagany.")]
        [Phone(ErrorMessage = "Wprowadź poprawny numer telefonu.")]
        public string phoneNumber { get; set; }

        [Required(ErrorMessage = "Wiek jest wymagany.")]
        [Range(11, 80, ErrorMessage = "Wiek musi być między 11 a 80.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Wybierz swoje miasto")]
        public string City { get; set; }

        public enum Cities
        {
            Kraków,
            Wrocław,
            Przemyśl,
            Rzeszów,
            Warszawa
        }
    }
}