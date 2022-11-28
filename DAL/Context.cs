using Logic.Domain.Products;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options)
        : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;


    }
}
