using Logic.Domain.Users;
using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OnlineStoreV1.Pages.Users
{
    public class UsersModel : PageModel
    {
       IUnitOfWork _unitOfWork;

        public UsersModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IAsyncEnumerable<User> Users { get; set; }
        public void OnGet()
        {
            Users = _unitOfWork.UserRepository.GetAll();
        }
    }
}
