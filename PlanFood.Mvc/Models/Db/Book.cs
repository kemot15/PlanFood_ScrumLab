using System.ComponentModel.DataAnnotations;

namespace PlanFood.Mvc.Models.Db
{
	public class Book
	{
		public int Id { get; set; }

		[Required, StringLength(255)]
		public string Title { get; set; }

		[Required, StringLength(255)]
		public string Author { get; set; }

		[Required, StringLength(255)]
		public string Isbn { get; set; }
	}
}
