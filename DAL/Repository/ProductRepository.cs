using Logic.Domain.Products;
using Logic.Interfaces;

namespace DAL.Repository
{
    public class ProductRepository: IProductRepository
    {
        private Context _context;
        public ProductRepository(Context context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }
        public Product FindById(int id)
        {
            return _context.Products.FirstOrDefault(x => x.Id == id);
        }

    }
}
