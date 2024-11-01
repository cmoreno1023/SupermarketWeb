using System.ComponentModel.DataAnnotations;

namespace SupermarketWEB.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Invoice number is required")]
        public string InvoiceNumber { get; set; } = default!;

        [Required(ErrorMessage = "Invoice date is required")]
        public DateTime InvoiceDate { get; set; }

        // Propiedad de navegación para Products
        public virtual ICollection<Product>? Products { get; set; }
    }
}
