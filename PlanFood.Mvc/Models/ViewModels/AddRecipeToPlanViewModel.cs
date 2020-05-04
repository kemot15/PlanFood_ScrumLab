using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlanFood.Mvc.Models.ViewModels
{
    public class AddRecipeToPlanViewModel
    {
        [Required(ErrorMessage = "Pole wymagane!")]
        public string ChoosePlan { get; set; }
        public IList<SelectListItem> ChoosePlans { get; set; }
        [Required(ErrorMessage = "Pole wymagane!"), StringLength(245)]
        public string MealName { get; set; }
        [Required(ErrorMessage ="Pole wymagane!")]
        public int DisplayOrder { get; set; }
        [Required(ErrorMessage = "Pole wymagane!")]
        public string Recipe { get; set; }
        public IList<SelectListItem> Recipes { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        public string DayName { get; set; }
        public IList<SelectListItem> DayNames { get; set; }
    }
}
