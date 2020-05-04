using PlanFood.Mvc.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanFood.Mvc.Models.ViewModels
{
    public class DashboardViewModel
    {
        public int RecipeNumber { get; set; }
        public int PlanNumber { get; set; }
        public Plan Plan { get; set; }
        public IList<DayName> DayNames { get; set; }
    }
}
