using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlanFood.Mvc.Models.Db;
using PlanFood.Mvc.Services;
using PlanFood.Mvc.Services.Interfaces;

namespace PlanFood.Mvc.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IAdminService _adminService;

        public AdminController(UserManager<User> userManager, IAdminService adminService)
        {
            _userManager = userManager;
            _adminService = adminService;
        }

        public async Task<IActionResult> Show()
        {
            var users = await _userManager.GetUsersInRoleAsync("user");            
            return View(users);
        }

        public async Task<IActionResult> Lock (int id)            
        {
            await _adminService.UserLockAsync(id);                       
            return RedirectToAction("Show");
        }

        public async Task<IActionResult> Unlock(int id)
        {
            await _adminService.UserUnlockAsync(id);
            return RedirectToAction("Show");
        }
    }
}