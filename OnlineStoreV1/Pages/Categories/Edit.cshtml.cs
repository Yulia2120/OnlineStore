using DAL;
using Logic.Domain.Products;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.Entity.Infrastructure;

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
        public async Task<IActionResult> OnGet(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            await _unitOfWork.CategoryRepository.Find(id);
            if (id == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Category item)
        {
                await _unitOfWork.CategoryRepository.Find(Category.Id);
                item.Name = Category.Name;
                item.Description = Category.Description;

                await _unitOfWork.CategoryRepository.UpdateAsync(item);
                return RedirectToAction("");
            
        }
       
    }
}
