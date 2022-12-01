using Logic.Domain.Products;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OnlineStoreV1.Pages.Products
{
    public class DetailsModel : PageModel
    {
        IUnitOfWork _unitOfWork;

        public DetailsModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Product Product { get; private set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Product = await _unitOfWork.ProductRepository.GetByIdAsync(id);
            return Page();
        }
    }
}
