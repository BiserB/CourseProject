using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Vote.App.Infrastructure.Hubs;
using Vote.Common;
using Vote.Common.BindingModels;
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

            if (TempData["Message"] != null)
            {
                ViewData["Message"] = TempData["Msg"];
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

            var dbEvent = this.service.GetEvent(model, userId);

            if (dbEvent == null)
            {
                return LocalRedirect("/manager/activities/index");
            }

            var isSaved = this.service.SaveEventChanges(model, dbEvent);

            if (isSaved)
            {
                return LocalRedirect("/manager/activities/index");
            }

            ViewData["Msg"] = "Event Code is occupied";

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UploadFiles(IFormFile logo)
        {
            var userId = await this.GetCurrentUserId();

            if (logo.Length > VoteConstants.LogoLength)
            {
                TempData["Msg"] = $"File size exceeds {VoteConstants.LogoLength} bytes!";

                return LocalRedirect("/identity/account/manage");
            }

            var extension = Path.GetExtension(logo.FileName);

            if (!VoteConstants.LogoExtensions.Contains(extension))
            {
                TempData["Msg"] = "Wrong file type";

                return LocalRedirect("/identity/account/manage");
            }
            
            var isUploaded = await this.service.UploadLogo(logo, userId);

            if (isUploaded)
            {
                return LocalRedirect("/identity/account/manage");
            }

            return LocalRedirect("/manager/activities/index");
        }

    }
}