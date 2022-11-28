using Logic.Domain.Products;

namespace Logic.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product FindById(int id);
    }
}
