using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlanFood.Mvc.Models.ViewModels
{
    public class EditUserViewModel
    {
        [Required(ErrorMessage = "Pole wymagane")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        [EmailAddress(ErrorMessage = "Nie poprawna adres email")]
        public string Email { get; set; }
    }
}
