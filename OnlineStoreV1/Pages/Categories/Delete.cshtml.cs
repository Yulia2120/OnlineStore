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
        public void OnGet()
        {
        }
        public async Task<IActionResult> Delete(Category category)
        {
            await _unitOfWork.CategoryRepository.Find(Category.Id);
            if (category == null)
            {
                return NotFound();
            }
            await _unitOfWork.CategoryRepository.DeleteAsync(category);
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("");
        }
    }
}
