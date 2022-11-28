using Logic.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface IProductRepository
    { 
        IEnumerable<Product> GetAll();
        Product FindById(int id);
    }
}
