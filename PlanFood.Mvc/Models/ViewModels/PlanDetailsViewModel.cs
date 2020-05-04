using PlanFood.Mvc.Models.Db;
using System.Collections.Generic;

namespace PlanFood.Mvc.Models.ViewModels
{
    public class PlanDetailsViewModel
    {
        public IList<DayName> DayNames { get; set; }
        public Plan Plan { get; set; }
    }
}
