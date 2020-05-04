using Microsoft.EntityFrameworkCore;
using PlanFood.Mvc.Context;
using PlanFood.Mvc.Models.Db;
using PlanFood.Mvc.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanFood.Mvc.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly PlanFoodContext _context;

        public RecipeService(PlanFoodContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateAsync(Recipe recipe)
        {
            await _context.Recipes.AddAsync(recipe);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Recipe> GetAsync(int id)
        {
            return await _context.Recipes.SingleOrDefaultAsync(b => b.Id == id);
        }

        public async Task<IList<Recipe>> GetAllAsync()
        {
            return await _context.Recipes.OrderByDescending(recipe => recipe.Created).ToListAsync();
        }

        public async Task<IList<Recipe>> GetAllContainsNameAsync(string search, User user = null)
        {
            if (user != null)
                return await _context.Recipes.Include(recipe => recipe.RecipePlans).Where(recipe => recipe.User.Equals(user) && recipe.Name.Contains(search)).OrderByDescending(recipe => recipe.Created).ToListAsync();

            return await _context.Recipes.Where(recipe => recipe.Name.Contains(search)).ToListAsync();

        }

        public async Task<bool> UpdateAsync(Recipe recipe)
        {
            _context.Recipes.Update(recipe);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var recipe = await _context.Recipes.SingleOrDefaultAsync(b => b.Id == id);
            if (recipe == null)
                return false;
            _context.Recipes.Remove(recipe);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<int> CountRecipesAsync(User user)
        {
            return await _context.Recipes.Where(recipe => recipe.User.Equals(user)).CountAsync();
        }

        public async Task<IList<Recipe>> RecipeUserListAsync(User user)
        {
            return await _context.Recipes.Include(recipePlan => recipePlan.RecipePlans).Where(recipe => recipe.User.Equals(user)).OrderByDescending(recipe => recipe.Created).ToListAsync();
        }
    }
}
