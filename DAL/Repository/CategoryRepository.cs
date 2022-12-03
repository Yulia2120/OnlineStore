using Logic.Domain.Products;
using Logic.Interfaces;
using System.Data.Entity;

namespace DAL.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {

        public CategoryRepository(Context context) : base(context)
        {
        }
        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }
    } 
        
}
