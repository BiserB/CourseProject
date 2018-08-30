using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vote.Common;
using Vote.Data;
using Vote.Entities;

namespace Vote.App.Areas.Manager.Controllers
{
    [Area(RoleType.Manager)]
    [Authorize(Roles = RoleType.Manager + "," + RoleType.Admin + "," + RoleType.SysAdmin)]
    public abstract class BaseManagerController : Controller
    {
        private UserManager<User> userManager;

        public BaseManagerController(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }
        
        protected async Task<User> GetCurrentUser()
        {
            var principal = this.HttpContext.User;

            var currentUser = await this.userManager.GetUserAsync(principal);

            return currentUser;
        }

        protected async Task<string> GetCurrentUserId()
        {
            return (await this.GetCurrentUser()).Id;
        }

        protected bool UserIsManager()
        {
            var isManager = this.HttpContext.User.IsInRole(RoleType.Manager);

            return isManager;
        }

        
    }
}
