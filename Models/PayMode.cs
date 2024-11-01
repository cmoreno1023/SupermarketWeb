using System.ComponentModel.DataAnnotations;

namespace SupermarketWEB.Models
{
    public class PayMode
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [MaxLength(50)]
        public string Name { get; set; } = default!;

        [Required(ErrorMessage = "Description is required")]
        [Display(Name = "Description")]
        [MaxLength(200)]
        public string Description { get; set; } = default!;
    }
}
