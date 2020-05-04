using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PlanFood.Mvc.Models.Db;
using PlanFood.Mvc.Models.ViewModels;
using PlanFood.Mvc.Services.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PlanFood.Mvc.Controllers
{
    [Authorize]
    public class PlanController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IPlanService _planService;
        private readonly IDayNameService _dayNameService;
        private readonly IRecipeService _recipeService;

        public PlanController(UserManager<User> userManager, IPlanService planService, IDayNameService dayNameService, IRecipeService recipeService)
        {
            _userManager = userManager;
            _planService = planService;
            _dayNameService = dayNameService;
            _recipeService = recipeService;
        }
        public async Task<IActionResult> List()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
                return Unauthorized();

            var planList = await _planService.GetUserPlanAsync(user);
            return View(planList);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddPlanViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                ModelState.AddModelError("", "Błąd dodawania planu");
                return View(model);
            }

            var plan = new Plan()
            {
                Name = model.Name,
                Description = model.Description,
                Created = DateTime.Now,
                User = user
            };

            var result = await _planService.CreateAsync(plan);

            if (result == false)
            {
                ModelState.AddModelError("", "Błąd dodawania planu");
                return View(model);
            }

            return RedirectToAction("List", "Plan");
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {

            var viewModel = new PlanDetailsViewModel()
            {
                Plan = await _planService.GetWithDetailsAsync(id),
                DayNames = await _dayNameService.GetAllAsync()
            };
            return View(viewModel);
        }
        [HttpGet]
        public async Task<IActionResult> AddRecipe()
        {
            var viewModel = new AddRecipeToPlanViewModel();
            var user = await _userManager.GetUserAsync(User);
            var plans = await _planService.GetUserPlanAsync(user);
            var days = await _dayNameService.GetAllAsync();
            var recipes = await _recipeService.RecipeUserListAsync(user);
            viewModel.ChoosePlans = plans.Select(plan => new SelectListItem() { Text = plan.Name, Value = plan.Id.ToString() }).ToList();
            viewModel.DayNames = days.Select(day => new SelectListItem() { Text = day.Name, Value = day.Id.ToString() }).ToList();
            viewModel.Recipes = recipes.Select(recipe => new SelectListItem() { Text = recipe.Name, Value = recipe.Id.ToString() }).ToList();
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddRecipe(AddRecipeToPlanViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var recipePlan = new RecipePlans
            {
                DisplayOrder = model.DisplayOrder,
                MealName = model.MealName,
                PlanId = int.Parse(model.ChoosePlan),
                DayNameId = int.Parse(model.DayName),
                RecipeId = int.Parse(model.Recipe)
            };

            var result = await _planService.AddRecipeToPlanAsync(recipePlan);

            if (result == false)
            {
                ModelState.AddModelError("", "Błąd dodawania planu");
                return View(model);
            }

            return RedirectToAction("AddRecipe", "Plan");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var planToEdit = await _planService.GetAsync(id);
            var viewModel = new EditPlanViewModel()
            {
                Id = planToEdit.Id,
                Description = planToEdit.Description,
                Name = planToEdit.Name,
                Created = planToEdit.Created
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditPlanViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                ModelState.AddModelError("", "Błąd edycji planu");
                return View(model);
            }

            var plan = new Plan()
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                Created = model.Created,
                User = user
            };

            var result = await _planService.UpdateAsync(plan);

            if (result == false)
            {
                ModelState.AddModelError("", "Błąd edycji planu");
                return View(model);
            }

            return RedirectToAction("List", "Plan");
        }

        [HttpGet]
        public async Task<IActionResult> Remove(int id)
        {
            await _planService.DeleteAsync(id);
            return RedirectToAction("List");
        }

        [HttpGet]
        public async Task<IActionResult> ConfirmRemoveRecipe(int id, int planId) 
        {
            await _planService.RemoveRecipeToPlanAsync(id);
            return RedirectToAction("Details", new {id = planId});
        }

    }
}