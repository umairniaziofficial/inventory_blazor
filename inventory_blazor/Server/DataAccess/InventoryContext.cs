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

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
