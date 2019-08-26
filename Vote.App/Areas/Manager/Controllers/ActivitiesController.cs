using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using Vote.App.Infrastructure.Hubs;
using Vote.Common.BindingModels;
using Vote.Entities;
using Vote.Services.Manager.Interfaces;

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

            if (!this.UserIsManager())
            {
                return LocalRedirect("/main/home/index");
            }

            string userId = await this.GetCurrentUserId();

            var isCreated = this.service.CreateEvent(model, userId);

            if (isCreated)
            {
                return LocalRedirect("/manager/activities/index");
            }

            ViewData["Msg"] = "Event Code is occupied";

            return this.View(model);            
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

            return LocalRedirect("/main/home/index");
        }

        [HttpGet]
        public async Task<IActionResult> Display(int id)
        {
            string userId = await this.GetCurrentUserId();

            var dbEventModel = this.service.GetEventFullModel(id, userId);

            if (dbEventModel == null)
            {
                return LocalRedirect("/manager/activities/index");
            }

            return this.View(dbEventModel);
        }
    }
}