using Logic.Domain.Products;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OnlineStoreV1.Pages.Categories
{
    public class CategoriesModel : PageModel
    {
        
        IUnitOfWork _unitOfWork;

        public CategoriesModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
       [BindProperty]
        public Category Category { get;set; }
        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPost(Category category)
        {
            if(category.Name == category.Description)
            {
                ModelState.AddModelError("name", "The Description cannot exactly match the Name.");
            }
            if (ModelState.IsValid)
            {
                await _unitOfWork.CategoryRepository.CreateAsync(category);
                return RedirectToAction("");
            }
            else
            {
                return Page();
            }
        }

        


    }
}
