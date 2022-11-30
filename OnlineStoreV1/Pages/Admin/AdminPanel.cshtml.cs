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

        public IEnumerable<Product> Categories { get; private set; }

        public void OnGet()
        {
            Categories = _unitOfWork.ProductRepository.GetAll();
        }
    }
}
