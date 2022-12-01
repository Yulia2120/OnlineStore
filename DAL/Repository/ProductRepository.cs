using Logic.Domain.Products;
using Logic.Interfaces;
using System.Linq;

namespace DAL.Repository
{
    public class ProductRepository:  Repository<Product>, IProductRepository
    {
        public ProductRepository(Context context) : base(context)
        {
        }
        //public IEnumerable<Product> GetAll()
        //{
        //    return _context.Set<Product>().ToList();
        //    //return _context.Set<Product>().Take(10).ToList(); //возвращает 10 единиц
        //}
        //public Product FindById(int id)
        //{
        //    return _context.Products.FirstOrDefault(x => x.Id == id);
        //}

    }
}
