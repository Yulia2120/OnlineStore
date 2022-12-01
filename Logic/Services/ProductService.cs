using Logic.Domain.Products;
using Logic.Interfaces;

namespace Logic.Services
{
    public class ProductService
    {
        IUnitOfWork _unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        //public Product GetProduct( int id)
        //{
        //    _unitOfWork.ProductRepository.FindById(id);
        //    return new Product();
        //}
    }
}
