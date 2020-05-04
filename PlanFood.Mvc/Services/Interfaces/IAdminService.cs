using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanFood.Mvc.Services.Interfaces
{
    public interface IAdminService
    {
        Task<bool> UserLockAsync (int id);
        Task<bool> UserUnlockAsync(int id);
    }
}
