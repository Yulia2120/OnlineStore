using Logic.Domain.Products;
using Microsoft.AspNetCore.Mvc;


namespace OnlineStoreV1.Controllers
{
    public class AdminController : Controller
    {
        //GET: Admin
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(Category category)
        {
            return View();
        }
    }
}
