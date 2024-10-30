namespace SupermarketWEB.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? description { get; set; }
        public ICollection<Product>? Products { get; set; } = default!;
    }
}
