using PlanFood.Mvc.Models.Db;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlanFood.Mvc.Services.Interfaces
{
    public interface IPlanService
    {
        Task<bool> CreateAsync(Plan plan);
        Task<Plan> GetAsync(int id);
        Task<Plan> GetWithDetailsAsync(int id);
        Task<IList<Plan>> GetAllAsync();
        Task<IList<Plan>> GetUserPlanAsync(User user);
        Task<bool> UpdateAsync(Plan plan);
        Task<bool> DeleteAsync(int id);
        Task<int> CountUserPlanAsync(User user);
        Task<Plan> GetLastAddPlanAsync(User user);
        Task<bool> AddRecipeToPlanAsync(RecipePlans recipePlans);
        Task<bool> RemoveRecipeToPlanAsync(int id);
    }
}
