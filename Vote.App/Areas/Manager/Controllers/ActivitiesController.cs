using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Vote.App.Infrastructure.Hubs;
using Vote.Common.BindingModels;
using Vote.Common.ViewModels.Events;
using Vote.Data;
using Vote.Entities;
using Vote.Services.Manager.Interfaces;
using System.IO;

namespace Vote.App.Areas.Manager.Controllers
{
    public class ActivitiesController : BaseManagerController
    {
        private readonly IManagerActivitiesService service;
        private readonly IHubContext<VoteHub> hubContext;

        public ActivitiesController(UserManager<User> userManager,
                                    IManagerActivitiesService service,
                                    IHubContext<VoteHub> hubContext) 
            : base(userManager)
        {
            this.service = service;
            this.hubContext = hubContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var userId = await this.GetCurrentUserId();

            var eventList = this.service.GetAllEventsForUser(userId);
            
            return View(eventList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var user = this.HttpContext.User;

            var model = this.service.GetEventModel();

            return View(model);
        }


        [HttpPost]        
        public async Task<IActionResult> Create(CreateEventBindingModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            string userId = await this.GetCurrentUserId();

            this.service.CreateEvent(model, userId);

            return LocalRedirect("/manager/activities/index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            string userId = await this.GetCurrentUserId();

            var isDeleted = this.service.DeleteEvent(id, userId);

            if (isDeleted)
            {
                return RedirectToAction("Index");
            }
            return LocalRedirect("/home/index");
        }

        [HttpGet]
        public IActionResult Display(int id)
        {
            var dbEventModel = this.service.GetEventFullModel(id);

            return this.View(dbEventModel);
        }

    }
}