using Microsoft.AspNetCore.Mvc;
using PlanFood.Mvc.Models.ViewModels;
using PlanFood.Mvc.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace PlanFood.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRecipeService _recipeService;

        public HomeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Info()
        {
            return View();
        }

        public async Task<IActionResult> Recipe([FromServices] IRecipeService recipeService,[FromQuery] string search)
        {
            var viewModel = new ListRecipeViewModel();

            if (string.IsNullOrWhiteSpace(search))
            {
                viewModel.RecipeList = await recipeService.GetAllAsync();

            }
            else
            {
                viewModel.RecipeList = await recipeService.GetAllContainsNameAsync(search);
                viewModel.Search = search;
            }

            return View(viewModel);
        }

        public async Task<IActionResult> Details(int id)
        {
            var recipe = await _recipeService.GetAsync(id);
            return View(recipe);
        }
    }
}