using Microsoft.EntityFrameworkCore;

namespace Assesment5.Entity
{
    public class Assesment5context: DbContext
    {
        private IConfiguration _configuration;
        public Assesment5context(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("Assesment5Connection"));
        }
    }
}
