using System.ComponentModel.DataAnnotations;

namespace SupermarketWEB.Models
{
    public class Provider
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Document Number is required")]
        [Display(Name = "Document Number")]
        [MaxLength(20)]
        public string DocumentNumber { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "First Name")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "Last Name")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Display(Name = "Phone")]
        [MaxLength(15)]
        public string? Phone { get; set; }

        [Display(Name = "Address")]
        [MaxLength(100)]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }
    }
}
