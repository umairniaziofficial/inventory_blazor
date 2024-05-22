using Microsoft.EntityFrameworkCore;
using inventory_blazor.Shared.Models;

namespace inventory_blazor.Server.DataAccess
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options)
            : base(options)
        {
        }

        // DbSet properties for each entity
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }

        // Override OnModelCreating to configure entity relationships and other model-specific settings
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure primary keys, indexes, relationships, etc.
            // For example:
            modelBuilder.Entity<Brand>().HasKey(b => b.Bid);
            modelBuilder.Entity<Category>().HasKey(c => c.Cid);
            modelBuilder.Entity<Store>().HasKey(s => s.Sid);
            modelBuilder.Entity<Product>().HasKey(p => p.Pid);

            // Configure relationships if needed
            // For example:
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Brand)
                .WithMany(b => b.Products)
                .HasForeignKey(p => p.Bid);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.Cid);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Store)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.Sid);

            // Map column names
            modelBuilder.Entity<Product>()
                .Property(p => p.AddedDate)
                .HasColumnName("added_date");

            modelBuilder.Entity<Product>()
                .Property(p => p.PStock)
                .HasColumnName("p_stock");
        }
    }
}
