using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlanFood.Mvc.Models.ViewModels
{
    public class AddPlanViewModel
    {
        [Required(ErrorMessage = "Nazwa planu jest wymagana")]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
