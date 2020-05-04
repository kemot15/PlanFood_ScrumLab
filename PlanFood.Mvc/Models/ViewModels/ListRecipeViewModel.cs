using PlanFood.Mvc.Models.Db;
using System.Collections.Generic;

namespace PlanFood.Mvc.Models.ViewModels
{
    public class ListRecipeViewModel
    {
        public string Search { get; set; }
        public IList<Recipe> RecipeList { get; set; }
    }
}
