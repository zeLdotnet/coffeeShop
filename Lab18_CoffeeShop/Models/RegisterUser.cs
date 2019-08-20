using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab18_CoffeeShop.Models
{
    public class RegisterUser
    {
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string UserName { get; set; }
        public string NickName { get; set; }

        [Required(ErrorMessage ="Birthday is required")]
        public DateTime BirthDay { get; set; }

        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",ErrorMessage="Enter a valid e-mail")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
