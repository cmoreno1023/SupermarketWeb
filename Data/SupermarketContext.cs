using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Models;

namespace SupermarketWEB.Data
{
    public class SupermarketContext : DbContext
    {
        public SupermarketContext(DbContextOptions<SupermarketContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Provider> Providers { get; set; }

        public DbSet<PayMode> PayModes { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.ToTable("Providers");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.DocumentNumber).IsRequired().HasMaxLength(20);
                entity.Property(e => e.FirstName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.LastName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Phone).HasMaxLength(15);
                entity.Property(e => e.Address).HasMaxLength(100);
            });
        }
    }
}