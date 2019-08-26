using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;
using Vote.App.Infrastructure.Hubs;
using Vote.Common.BindingModels;
using Vote.Services.Participant.Interfaces;

namespace Vote.App.Areas.Participant.Controllers
{
    public class EventsController : BaseParticipantController
    {
        private readonly IParticipantEventsService service;
        private readonly IHubContext<VoteHub> hubContext;

        public EventsController(IParticipantEventsService service, IHubContext<VoteHub> hubContext)
                         : base()
        {
            this.service = service;
            this.hubContext = hubContext;
        }

        [HttpGet]
        public IActionResult Join(string code)
        {
            if (code == null)
            {
                return LocalRedirect(this.BaseUrl);
            }

            var dbEvent = this.service.GetEvent(code);

            if (dbEvent == null)
            {
                ViewData["Code"] = code;
                ViewData["Msg"] = $"No such event";

                return this.View("Result");
            }

            if (dbEvent.IsClosed)
            {
                ViewData["Code"] = code;
                ViewData["Msg"] = $"It is not active";

                return this.View("Result");
            }

            var today = DateTime.Today;

            if (dbEvent.EndDate < today)
            {
                ViewData["Code"] = code;
                ViewData["Msg"] = $"It is a past event.";

                return this.View("Result");
            }

            var joinModel = this.service.CreateEventModel(dbEvent);

            return View(joinModel);
        }

        [HttpPost]
        public async Task<IActionResult> Ask(JoinEventViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return RedirectToAction("Join", new { code = model.EventCode });
            }

            var qn = this.service.CreateQuestion(model);

            if (qn == null)
            {
                return RedirectToAction("Join", new { code = model.EventCode });
            }

            this.service.SaveQuestion(qn);

            if (qn.IsReviewed)
            {
                await this.hubContext.Clients.Group(model.EventCode)
                                .SendAsync("Callback", qn.Content, qn.PublishedOn.ToShortDateString(), qn.AuthorName, qn.Id, model.EventId, model.EventCode);
            }

            await this.hubContext.Clients.Group(model.EventCode)
                                .SendAsync("ForManager", qn.Content, qn.PublishedOn.ToShortDateString(), qn.AuthorName, qn.Id);


            return RedirectToAction("Join", new { code = model.EventCode });
        }
    }
}