using System.ComponentModel.DataAnnotations;

namespace PlanFood.Mvc.Models.Db
{
    public class RecipePlans
    {
        public int ID { get; set; }
        public int DayNameId { get; set; }
        public DayName DayName { get; set; }
        public int DisplayOrder { get; set; }
        [Required, StringLength(245)]
        public string MealName { get; set; }
        public int PlanId { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
