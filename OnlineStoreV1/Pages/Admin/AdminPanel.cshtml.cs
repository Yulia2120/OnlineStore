
using Logic.Domain.Products;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OnlineStoreV1.Pages.Admin
{
    public class AdminPanelModel : PageModel
    {
        IUnitOfWork _unitOfWork;

        public AdminPanelModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Category> Categories { get; private set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Categories = await _unitOfWork.CategoryRepository.GetAllAsync();
            return Page();
        }
       
    }
}
