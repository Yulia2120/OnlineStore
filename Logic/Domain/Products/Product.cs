using Logic.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logic.Domain.Products
{
    public class Product: IIdentity
    {
        [StringLength(200)]
        public string? Name { get; set; }
        [StringLength(200)]
        public string? DescrLi { get; set; }
        [StringLength(200)]
        public string? DescrLiSecond { get; set; }
        [StringLength(2000)]
        public string? Description { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        [StringLength(2000)]
        public string? ImgUrl { get; set; }
        public bool IsActive
        {
            get
            {
                {
                    if (Quantity > 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
        }
        public Category Category { get; set; } = null!;

    }
}
