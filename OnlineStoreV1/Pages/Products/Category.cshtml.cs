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
        public IEnumerable<Product> Products { get; set; }
        public void OnGet()
        {
            Products = _unitOfWork.ProductRepository.GetAll();
        }
    }
}
