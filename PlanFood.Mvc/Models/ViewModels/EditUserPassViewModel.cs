using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlanFood.Mvc.Models.ViewModels
{
    public class EditUserPassViewModel
    {
        [Required(ErrorMessage = "Pole wymagane")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Pole wymagane"), Compare("Password", ErrorMessage ="Hasła nie są zgodne")]
        [DataType(DataType.Password)]
        public string ReapeatPassword { get; set; }
    }
}
