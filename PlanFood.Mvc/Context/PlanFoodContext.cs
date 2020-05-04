using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PlanFood.Mvc.Models.Db;


namespace PlanFood.Mvc.Context
{
	public class PlanFoodContext : IdentityDbContext<User, IdentityRole<int>, int>
	{		
		public PlanFoodContext(DbContextOptions<PlanFoodContext> options) : base(options)
		{
		}
		protected override void OnModelCreating(ModelBuilder builder)
		{
			
			builder.Entity<IdentityRole<int>>().HasData(
				new IdentityRole<int> { Id = 1, Name = "Admin", NormalizedName = "Admin" },
				new IdentityRole<int> { Id = 2, Name = "User", NormalizedName = "USER" });
			builder.Entity<DayName>().HasData(
				new DayName { Id = 1, Name = "Poniedziałek", DisplayOrder = 1},
				new DayName { Id = 2, Name = "Wtorek", DisplayOrder = 2 },
				new DayName { Id = 3, Name = "Środa", DisplayOrder = 3 },
				new DayName { Id = 4, Name = "Czwartek", DisplayOrder = 4 },
				new DayName { Id = 5, Name = "Piątek", DisplayOrder = 5 },
				new DayName { Id = 6, Name = "Sobota", DisplayOrder = 6 },
				new DayName { Id = 7, Name = "Niedziela", DisplayOrder = 7 }
				);
			base.OnModelCreating(builder);
		}

		public DbSet<Book> Books { get; set; }
		public DbSet<Recipe> Recipes { get; set; }
		public DbSet<RecipePlans> RecipePlans { get; set; }
		public DbSet<DayName> DayNames { get; set; }
		public DbSet<Plan> Plans { get; set; }
	}
}
