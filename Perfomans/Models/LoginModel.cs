using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Perfomans.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Укажите другую почту")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Укажите другой пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
