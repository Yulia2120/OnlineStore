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
        [HttpGet]
        public async Task<IActionResult> IndexAsync()
        {
            Categories = await _ofWork.CategoryRepository.GetAllAsync();
            return View();
        }
       
    }
}
