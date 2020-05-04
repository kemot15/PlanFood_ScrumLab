using System;
using System.ComponentModel.DataAnnotations;

namespace PlanFood.Mvc.Models.ViewModels
{
    public class AddRecipeViewModel
    {
        [Required(ErrorMessage = "Pole wymagane")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        public string Ingredients { get; set; }

        [Required(ErrorMessage = "Pole wymagane")]
        [Range(0, int.MaxValue, ErrorMessage = "Wartść musi być dodatnia")]
        public int PreparationTime { get; set; }

        [Required(ErrorMessage = "Pole wymagane")]

        public string Preparation { get; set; }
    }
}
