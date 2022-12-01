using Logic.Domain.Products;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OnlineStoreV1.Pages.Categories
{
    public class EditModel : PageModel
    {
        IUnitOfWork _unitOfWork;

        public EditModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [BindProperty]
        public Category Category { get; set; }
        public async Task<IActionResult> OnEdit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            await _unitOfWork.CategoryRepository.UpdateAsync(id);
            if (id == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
