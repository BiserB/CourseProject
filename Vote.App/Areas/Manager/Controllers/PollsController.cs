using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Vote.Common.BindingModels;
using Vote.Entities;
using Vote.Services.Manager.Interfaces;

namespace Vote.App.Areas.Manager.Controllers
{
    public class PollsController : BaseManagerController
    {
        private IManagerPollsService service;

        public PollsController(UserManager<User> userManager, IManagerPollsService service)
            : base(userManager)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult Index(int id)
        {
            var pollsPanelModel = this.service.GetPollsPanel(id);

            if (pollsPanelModel.IsPastEvent)
            {
                return View("IndexPastEvent", pollsPanelModel);
            }

            return View(pollsPanelModel);
        }

        [HttpGet]
        public IActionResult Create(int id)
        {
            var pollModel = this.service.CreatePollModel(id);

            return View(pollModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PollBindingModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return View(model);
            }

            if (!this.UserIsManager())
            {
                return LocalRedirect("/home/index");
            }

            var userId = await this.GetCurrentUserId();

            var pollCreated = await this.service.CreatePollAsync(model, userId);

            if (!pollCreated)
            {
                return LocalRedirect("/home/index");
            }

            return RedirectToAction("Index", new { id = model.EventId });
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var pollDetailsModel = this.service.GetPollDetails(id);

            if (pollDetailsModel == null)
            {
                return LocalRedirect("/home/index");
            }

            return this.View(pollDetailsModel);
        }

        [HttpPost]
        public IActionResult Activate(int id, int eventId)
        {
            this.service.SetIsActivePoll(id, eventId);

            return this.RedirectToAction("Index", new { id = eventId });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, int eventId)
        {
            var userId = await this.GetCurrentUserId();

            var isDeleted = this.service.DeletePoll(id, eventId, userId);

            if (!isDeleted)
            {
                return LocalRedirect("/home/index");
            }

            return this.RedirectToAction("Index", new { id = eventId });
        }
    }
}