using Logic.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Logic.Domain.Products
{
    public class Category: IIdentity
    {
       public Category()
        {
            Products = new List<Product>();

        }
        //[Required]
        [StringLength(155)]
        public string? Name { get; set; }
        [StringLength(2000)]
        public string? Description { get; set; }
        public bool IsActive { 
            get 
            {
              return Products.Any() ? true : false;
            }
            }
        public List<Product> Products { get; set; } = null!;

    }
}