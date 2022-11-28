using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Domain.Products
{
    public class Product: IIdentity
    {
        public int Id { get; set; }
        [StringLength(200)]
        public string? Name { get; set; }
        [StringLength(2000)]
        public string? Description { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        [StringLength(2000)]
        public string? UrlImg { get; set; }
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
        public Category? Category { get; set; }

    }
}
