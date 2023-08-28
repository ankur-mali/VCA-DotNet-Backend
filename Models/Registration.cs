using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VCA.Models
{
    [Table("registration")]
    public class Registration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Password correction")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Company name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Company name length must be between 3 and 100 characters")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Address line 1 is required")]
        [StringLength(100, ErrorMessage = "Address line 1 length must not exceed 100 characters")]
        public string AddressLine1 { get; set; }

        [StringLength(100, ErrorMessage = "Address line 2 length must not exceed 100 characters")]
        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(50, ErrorMessage = "City name length must not exceed 50 characters")]
        public string City { get; set; }

        [Required(ErrorMessage = "State is required")]
        [StringLength(50, ErrorMessage = "State name length must not exceed 50 characters")]
        public string State { get; set; }

        [Required(ErrorMessage = "PIN code is required")]
        [RegularExpression("^[0-9]{6}$", ErrorMessage = "PIN code must be a 6-digit number")]
        public string PinCode { get; set; }

        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Invalid phone number format")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Authorized person name is required")]
        [StringLength(100, ErrorMessage = "Authorized person name length must not exceed 100 characters")]
        public string AuthorizedPersonName { get; set; }

        [RegularExpression("^[0-9A-Z]{15}$", ErrorMessage = "Invalid GST number format")]
        public string GstNumber { get; set; }
    }
}
