using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWEB.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Invoice ID is required")]
        public int InvoiceId { get; set; }

        [ForeignKey("InvoiceId")]
        public virtual Invoice? Invoice { get; set; }

        [Required(ErrorMessage = "Product ID is required")]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Stock is required")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }
    }
}