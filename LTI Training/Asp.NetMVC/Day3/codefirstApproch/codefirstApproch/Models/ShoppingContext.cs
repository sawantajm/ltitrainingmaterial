using Microsoft.EntityFrameworkCore;

namespace codefirstApproch.Models
{
    public class ShoppingContext:DbContext

    {

        public ShoppingContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Product> products { get; set; }
    }
}
