using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlanFood.Mvc.Models.Db
{
    public class DayName
    {
        public int Id { get; set; }
        [Required]
        public int DisplayOrder { get; set; }
        [Required, StringLength(45)]
        public string Name { get; set; }
        public ICollection<RecipePlans> RecipePlans {get; set;}
    }
}
