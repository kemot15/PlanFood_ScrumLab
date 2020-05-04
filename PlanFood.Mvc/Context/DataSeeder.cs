using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using PlanFood.Mvc.Models.Db;
using PlanFood.Mvc.Tools;
using System.Linq;
using System.Threading.Tasks;

namespace PlanFood.Mvc.Context
{
    public static class DataSeeder
    {
        public static IApplicationBuilder SeedAdminUser(this IApplicationBuilder app)
        {
            using var service = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
            var planFoodContext = service.ServiceProvider.GetRequiredService<PlanFoodContext>();
            var userManager = service.ServiceProvider.GetRequiredService<UserManager<User>>();

            var configuration = AppVariableConfiguration.ConfigurationRoot();

            if (planFoodContext.Users.Any()) return app;

            var user = new User()
            {
                UserName = configuration.GetSection("AdminUser:AdminLogin").Value,
                Name = configuration.GetSection("AdminUser:AdminName").Value,
                Email = configuration.GetSection("AdminUser:AdminEmail").Value
            };
            var userTask = userManager.CreateAsync(user, configuration.GetSection("AdminUser:AdminPassword").Value);
            Task.WaitAll(userTask);

            var roleTask = userManager.AddToRoleAsync(user, "admin");
            Task.WaitAll(roleTask);
            return app;
        }
    }
}
