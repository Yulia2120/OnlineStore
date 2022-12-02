using Logic.Domain.Products;
using Logic.Domain.Users;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class Context: DbContext/*IdentityDbContext<IdentityUser>*/
    {
        public Context(DbContextOptions<Context> options)
        : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<User> Users { get; set; } = null!;
    }
}
