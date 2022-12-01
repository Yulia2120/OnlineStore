using Logic.Domain.Products;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OnlineStoreV1.Pages.Products
{
    public class CatalogModel : PageModel
    {
        IUnitOfWork _unitOfWork;

        public CatalogModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

     
        public List<Product> Products { get; private set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Products = await _unitOfWork.ProductRepository.GetAllAsync();
            return Page();
        }
    }
}
