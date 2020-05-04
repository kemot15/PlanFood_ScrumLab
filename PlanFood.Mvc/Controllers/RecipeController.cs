using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PlanFood.Mvc.Models.Db;
using PlanFood.Mvc.Models.ViewModels;
using PlanFood.Mvc.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace PlanFood.Mvc.Controllers
{
    [Authorize]
    public class RecipeController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IRecipeService _recipeService;

        public RecipeController(UserManager<User> userManager, IRecipeService recipeService)
        {
            _userManager = userManager;
            _recipeService = recipeService;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddRecipeViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                ModelState.AddModelError("", "Błąd dodawania przepisu.");
                return View(model);
            }

            var recipe = new Recipe()
            {
                Preparation = model.Preparation,
                Name = model.Name,
                PreparationTime = model.PreparationTime,
                Ingredients = model.Ingredients,
                Description = model.Description,
                User = user

            };

            var result = await _recipeService.CreateAsync(recipe);

            if (result == false)
            {
                ModelState.AddModelError("", "Błąd dodawania przepisu.");
                return View(model);
            }

            return RedirectToAction("List", "Recipe");
        }

        [HttpGet]
        public async Task<IActionResult> List([FromQuery] string search)
        {

            var user = await _userManager.GetUserAsync(User);

            var viewModel = new ListRecipeViewModel();

            if (string.IsNullOrWhiteSpace(search))
            {
                viewModel.RecipeList = await _recipeService.RecipeUserListAsync(user);

            }
            else
            {
                viewModel.RecipeList = await _recipeService.GetAllContainsNameAsync(search, user);
                viewModel.Search = search;
            }

            return View(viewModel);

        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var recipe = await _recipeService.GetAsync(id);
            return View(recipe);
        }

        [HttpGet]
        public async Task<IActionResult> Remove(int id)
        {
            await _recipeService.DeleteAsync(id);
            return RedirectToAction("List");
        }       

        public async Task<IActionResult> Edit(int id)
        {
            var recipeToEdit = await _recipeService.GetAsync(id);

            var viewModel = new EditRecipeViewModel()
            {
                Id = recipeToEdit.Id,
                Description = recipeToEdit.Description,
                Name = recipeToEdit.Name,
                Ingredients = recipeToEdit.Ingredients,
                Preparation = recipeToEdit.Preparation,
                PreparationTime = recipeToEdit.PreparationTime,
                Created = recipeToEdit.Created,

            };
            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EditRecipeViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                ModelState.AddModelError("", "Błąd edycji przepisu.");
                return View(model);
            }

            var recipe = new Recipe()
            {
                Id = model.Id,
                Preparation = model.Preparation,
                Name = model.Name,
                PreparationTime = model.PreparationTime,
                Ingredients = model.Ingredients,
                Description = model.Description,
                Created = model.Created,
                Updated = DateTime.Now,
                User = user

            };

            var result = await _recipeService.UpdateAsync(recipe);

            if (result == false)
            {
                ModelState.AddModelError("", "Błąd edycji przepisu.");
                return View(model);
            }

            return RedirectToAction("List", "Recipe");
        }
    }
}