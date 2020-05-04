using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using PlanFood.Mvc.Models;
using PlanFood.Mvc.Models.Db;
using PlanFood.Mvc.Models.ViewModels;

namespace PlanFood.Mvc.Controllers
{    
    public class AccountController : Controller
    {
        protected UserManager<User> UserManager { get; }
        protected SignInManager<User> SignInManager { get; }

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            UserManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            SignInManager = signInManager ?? throw new ArgumentNullException(nameof(signInManager));
        }

        [HttpGet]
        public IActionResult Register()
        {
            ViewBag.Error = false;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromForm]RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    Name = registerViewModel.Name,
                    UserName = registerViewModel.Email,
                    Surname = registerViewModel.Surname,
                    Email = registerViewModel.Email,
                };
                var result = await UserManager.CreateAsync(user, registerViewModel.Password);
                if (result.Succeeded)
                {
                    await UserManager.AddToRoleAsync(user, "User");
                    return RedirectToAction("Login"); 
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            ViewBag.Error = true;
            return View(registerViewModel);
        }

        [HttpGet]
        public IActionResult Login() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LogInViewModel loginModel)
        {
            if (ModelState.IsValid)
            {
                var result = await SignInManager.PasswordSignInAsync(loginModel.Email, loginModel.Password, false, false);               

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
                //if (result.IsLockedOut)
                //{
                //    ModelState.AddModelError("", "Uzytkownik jest zablokowany");
                //   // return View(loginModel);
                //}

                if (result.IsLockedOut) 
                {
                    ModelState.AddModelError("", "Uzytkownik jest zablokowany");
                }
                else
                {
                    ModelState.AddModelError("", "Błąd logowania");
                }
            }
            return View(loginModel);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await SignInManager.SignOutAsync(); 
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> EditUser()
        {
            var user = await UserManager.GetUserAsync(User);
            var editUserViewModel = new EditUserViewModel
            {
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email
            };

            return View(editUserViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(EditUserViewModel editUserViewModel)
        {
            if (!ModelState.IsValid) return View(editUserViewModel);

            var user = await UserManager.GetUserAsync(User);
            if (user == null) return View("Login");
            user.Name = editUserViewModel.Name;
            user.Surname = editUserViewModel.Surname;
            user.Email = editUserViewModel.Email;
            var result = await UserManager.UpdateAsync(user);

            return Validation("Index", "Dashboard", result, editUserViewModel);
        }
            
        public IActionResult EditUserPass()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> EditUserPass(EditUserPassViewModel editUserPassViewModel)
        {
            if (!ModelState.IsValid) return View();

            var user = await UserManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Login");
            }

            var token = await UserManager.GeneratePasswordResetTokenAsync(user);
            var result = await UserManager.ResetPasswordAsync(user, token, editUserPassViewModel.Password);
            
            return Validation("Index", "Dashboard", result, null);
        }

        public IActionResult Validation (string action, string controller, IdentityResult result, Object model)
        {
            if (result.Succeeded)
            {
                return RedirectToAction(action, controller);
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return View();
        }
    }
}