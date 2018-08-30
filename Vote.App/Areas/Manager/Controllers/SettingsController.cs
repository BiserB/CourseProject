using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Vote.App.Infrastructure.Hubs;
using Vote.Common.BindingModels;
using Vote.Data;
using Vote.Entities;
using Vote.Services.Manager.Interfaces;

namespace Vote.App.Areas.Manager.Controllers
{
    public class SettingsController : BaseManagerController
    {

        private readonly IManagerSettingsService service;
        private readonly IHubContext<VoteHub> hubContext;

        public SettingsController(UserManager<User> userManager,
                                   IManagerSettingsService service,
                                    IHubContext<VoteHub> hubContext)
                            : base(userManager)
        {
            this.service = service;
            this.hubContext = hubContext;
        }

        [HttpGet]
        public async Task<IActionResult> SetupEvent(int id)
        {
            if (!this.UserIsManager())
            {
                return RedirectToAction("Index", controllerName: "Home");
            }

            var userId = await this.GetCurrentUserId();
            
            var model = this.service.GetEventSetupModel(id, userId);

            if (model == null)
            {
                return RedirectToAction("Index", controllerName: "Home");
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SetupEvent(EventSetupModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var userId = await this.GetCurrentUserId();

            var isSaved = this.service.SaveEventChanges(model, userId);

            if (isSaved)
            {
                return LocalRedirect("/manager/activities/index");
            }

            return LocalRedirect("/home/index");
        }
    }
}