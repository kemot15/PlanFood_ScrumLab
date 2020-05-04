using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanFood.Mvc.Models.Db
{
	public class Recipe
    {
        public Recipe()
        {
            Created = DateTime.Now;
        }
		public int Id { get; set; }

		[Required, StringLength(255)]
		public string Name { get; set; }

		[Required, MaxLength]
		public string Ingredients { get; set; }

		[MaxLength]
		public string Description { get; set; }
		[Column(TypeName = "datetime2(7)")]
		public DateTime Created { get; set; }
		[Column(TypeName = "datetime2(7)")]
		public DateTime? Updated { get; set; }

		[Required]
		public int PreparationTime { get; set; }

		[Required, MaxLength]
		public string Preparation { get; set; }
		public int? UserID { get; set; }
		public User User { get; set; }

		public ICollection<RecipePlans> RecipePlans { get; set; }
	}
}
