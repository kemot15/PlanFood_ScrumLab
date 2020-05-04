using Microsoft.AspNetCore.Identity;
using PlanFood.Mvc.Context;
using PlanFood.Mvc.Models.Db;
using PlanFood.Mvc.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanFood.Mvc.Services
{
    public class AdminService : IAdminService
    {
        private readonly UserManager<User> _userManager;
        private readonly PlanFoodContext _context;

        public AdminService(UserManager<User> userManager, PlanFoodContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<bool> UserLockAsync(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null) return false;
            user.LockoutEnabled = true;
            user.LockoutEnd = DateTime.MaxValue;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UserUnlockAsync(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null) return false;
            user.LockoutEnabled = false;
            user.LockoutEnd = null;
            return await _context.SaveChangesAsync() > 0; 
        }
    }
}
