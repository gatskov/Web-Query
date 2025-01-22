using Microsoft.EntityFrameworkCore;
using WebQuery.Models;

namespace WebQuery.DataBaseEntity
{
    public class ProductDbContext(DbContextOptions<ProductDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
         
    }
}
