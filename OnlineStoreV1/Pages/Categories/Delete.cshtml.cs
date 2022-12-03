using Logic.Domain.Products;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OnlineStoreV1.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        IUnitOfWork _unitOfWork;

        public DeleteModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [BindProperty]
        public Category Category { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            await _unitOfWork.CategoryRepository.Find(id);
            if(id == null)
            {
                return NotFound();
            }
            else
            {
                Category = Category;
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            await _unitOfWork.CategoryRepository.Find(id);

            await _unitOfWork.CategoryRepository.DeleteAsync(Category);

            return RedirectToPage("./AdminPanel");

        }
    }
}
