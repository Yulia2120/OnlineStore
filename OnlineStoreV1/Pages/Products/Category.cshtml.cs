using Logic.Domain.Products;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OnlineStoreV1.Pages.Products
{
    public class CategoryModel : PageModel
    {
        IUnitOfWork _unitOfWork;

        public CategoryModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<Product> products { get; set; }
        public void OnGet()
        {
            products = _unitOfWork.ProductRepository.GetAll();
        }
    }
}
