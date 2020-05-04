using PlanFood.Mvc.Models.Db;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlanFood.Mvc.Services.Interfaces
{
    public interface IDayNameService
    {
        Task<IList<DayName>> GetAllAsync();
    }
}
