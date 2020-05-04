using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanFood.Mvc.Models.ViewModels
{
    public class EditPlanViewModel:AddPlanViewModel
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }

    }
}
