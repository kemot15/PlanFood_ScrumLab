using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PlanFood.Mvc.Models.Db
{
    public class Plan
    {
        public int Id { get; set; }
        [Required, Column(TypeName = "datetime2(7)")]
        public DateTime Created { get; set; }
        [MaxLength]
        public string Description { get; set; }
        [Required(ErrorMessage = "Pole wymagane"), StringLength(45)]
        public string Name { get; set; }
        [Required, StringLength(450)]
        public int? UserId { get; set; }
        public User User { get; set; }
        public ICollection<RecipePlans> RecipePlans { get; set; }
    }
}
