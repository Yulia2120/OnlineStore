using Logic.Interfaces;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace Logic.Domain.Users
{
    public class User: IdentityUser
    {
       
        [Required]
        [StringLength(200)]
        public string? Name { get; set; }
        //[Required]
        //[DataType(DataType.EmailAddress)]
        //public string? Email { get; set; }
        //[Required]
        //[DataType(DataType.Password)]
        //public string? Password { get; set; }

    }
}
