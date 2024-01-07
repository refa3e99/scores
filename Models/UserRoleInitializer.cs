using Microsoft.AspNetCore.Identity;
using Scores.Data;

namespace Scores.Models
{
    public class UserRoleInitializer
    {
        public static async Task InitializeAsync(IServiceProvider serviceProvider, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {

            string[] rolesNames = { "Admin", "User" };

            IdentityResult roleResult;

            foreach (var roleName in rolesNames)
            {
                var roleExists = await roleManager.RoleExistsAsync(roleName);

                if (!roleExists)
                {
                    roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            var email = "admin@admin.com";

            if (userManager.FindByEmailAsync(email).Result == null)
            {
                ApplicationUser user = new()
                {
                    Email = email,
                    UserName = email,
                    EmailConfirmed = true,
                    LockoutEnabled = false
                };

                IdentityResult result = userManager.CreateAsync(user, "P@$$w0rd").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
        }
    }
}
