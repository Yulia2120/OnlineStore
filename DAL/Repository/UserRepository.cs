using Logic.Domain.Users;
using Logic.Interfaces;

namespace DAL.Repository
{
    public class UserRepository : IUserRepository
    {
       

        private Context _context;
        public UserRepository(Context context)
        {
            _context = context;
  
        }

        public IAsyncEnumerable<User> GetAll()
        {
            return _context.Set<User>().AsAsyncEnumerable();
        }
    }
}
