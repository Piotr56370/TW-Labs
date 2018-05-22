using Microsoft.EntityFrameworkCore;

namespace EShop.Models
{
    public class EShopContext : DbContext
    {
        public EShopContext (DbContextOptions<EShopContext> options)
            : base(options)
        {
        }

        public DbSet<EShop.Models.Product> Product { get; set; }
    }
}