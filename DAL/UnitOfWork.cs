using DAL.Repository;
using Logic.Interfaces;

namespace DAL
{
    public class UnitOfWork: IUnitOfWork
    {
        private Context _context;
        public UnitOfWork(Context context)
        {
            _context = context;
        }
        public IProductRepository ProductRepository 
        { get
            {

                return new ProductRepository(_context);
            }

        }
        public IUserRepository UserRepository
        {
            get
            {

                return new UserRepository(_context);
            }

        }

        public void Dispose() => GC.SuppressFinalize(this);
    }
}
