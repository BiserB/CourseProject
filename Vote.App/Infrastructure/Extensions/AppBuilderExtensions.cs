﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Vote.Common;
using Vote.Data;
using Vote.Entities;

namespace Vote.App.Infrastructure.Extensions
{
    public static class AppBuilderExtensions
    {
        private static readonly string AdminPass = "PASSword";

        private static readonly IdentityRole[] roles =
        {
            new IdentityRole(RoleType.Participant),
            new IdentityRole(RoleType.Manager),
            new IdentityRole(RoleType.Admin),
            new IdentityRole(RoleType.SysAdmin)
        };

        public static async void InitialDbSeed(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetService<VoteDbContext>();
                var roleManager = scope.ServiceProvider.GetService<RoleManager<IdentityRole>>();
                var userManager = scope.ServiceProvider.GetService<UserManager<User>>();

                dbContext.Database.Migrate();

                foreach (var role in roles)
                {
                    if (!await roleManager.RoleExistsAsync(role.Name))
                    {
                        await roleManager.CreateAsync(role);
                    }
                }

                var sysadmin = await userManager.FindByNameAsync("sysadmin");

                if (sysadmin == null)
                {
                    var user = new User()
                    {
                        UserName = "sysadmin",
                        Email = "sysadmin@mail.bg",
                        EmailConfirmed = true
                    };

                    await userManager.CreateAsync(user, AdminPass);

                    await userManager.AddToRoleAsync(user, RoleType.SysAdmin);
                }
            }
        }
    }
}