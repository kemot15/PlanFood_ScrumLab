using Microsoft.EntityFrameworkCore;
using PlanFood.Mvc.Context;
using PlanFood.Mvc.Models.Db;
using PlanFood.Mvc.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanFood.Mvc.Services
{
    public class DayNameService : IDayNameService
    {
        private readonly PlanFoodContext _context;

        public DayNameService(PlanFoodContext planFoodContext)
        {
            _context = planFoodContext;
        }
        public async Task<IList<DayName>> GetAllAsync()
        {
            return await _context.DayNames.OrderBy(dayName => dayName.DisplayOrder).ToListAsync();
        }
    }
}
