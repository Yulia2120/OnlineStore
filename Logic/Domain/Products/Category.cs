using Logic.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logic.Domain.Products
{
    public class Category: IIdentity
    {
       public Category()
        {
            Products = new List<Product>();

        }
        public new int  Id { get; set; }
        [Required]
        [StringLength(155)]
        public string? Name { get; set; }
        [StringLength(2000)]
        public string? Description { get; set; }
        [NotMapped]
        public bool IsActive { 
            get 
            {
              return Products.Any() ? true : false;
            }
            }
        public List<Product> Products { get; set; } = null!;

    }
}