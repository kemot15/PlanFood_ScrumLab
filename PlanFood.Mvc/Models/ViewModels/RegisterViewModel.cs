using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlanFood.Mvc.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Pole wymagane")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        [EmailAddress(ErrorMessage = "Nie poprawna adres email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Pole wymagane"), Compare("Password")]
        public string ReapeatPassword { get; set; }
    }
}
