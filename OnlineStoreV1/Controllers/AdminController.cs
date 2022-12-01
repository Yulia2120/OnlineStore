using DAL;
using Logic.Domain.Products;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace OnlineStoreV1.Controllers
{
    public class AdminController : Controller
    {
        private readonly IUnitOfWork _ofWork;

        public List<Category> Categories { get; private set; }

        public AdminController(IUnitOfWork ofWork)
        {
            _ofWork = ofWork;

        }
        public async Task<IActionResult> IndexAsync()
        {
            Categories = await _ofWork.CategoryRepository.GetAllAsync();
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> CreateCategory()
        {
            //Categories = await _ofWork.CategoryRepository.GetAllAsync();
            //return View();
            return View();
        }
        [HttpPost]
        public ActionResult CreateNewCategory(Category category)
        {
            return View();
        }

    }
}
