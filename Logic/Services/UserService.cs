using Logic.Domain.Users;
using Logic.Interfaces;

namespace Logic.Services
{
    public class UserService
    {
        IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public User GetUsers()
        {
           _unitOfWork.UserRepository.GetAll();
            return GetUsers();
        }

    }
}
