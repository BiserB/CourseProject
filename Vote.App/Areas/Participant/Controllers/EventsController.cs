using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Vote.Common.ViewModels.Events;
using Vote.Common;
using Vote.Data;
using Vote.Entities;
using Vote.Common.BindingModels;
using Vote.App.Infrastructure.Hubs;
using Vote.Services.Participant.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;

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
        public async Task<IActionResult> Join(string code)
        {
            if (code == null)
            {
                return LocalRedirect(this.BaseUrl);
            }

            var dbEvent = this.service.GetEvent(code);

            if (dbEvent == null)
            {
                return LocalRedirect("~/NoResult");
            }
            
            var joinModel = this.service.CreateEventModel(dbEvent);

            return View(joinModel);
        }

        [HttpPost]
        public async Task<IActionResult> Ask(JoinEventViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return RedirectToAction("Join", new { code = model.EventCode});
            }

            var q = this.service.CreateQuestion(model);

            if (q == null)
            {
                return RedirectToAction("Join", new { code = model.EventCode });
            }

            this.service.SaveQuestion(q);

            await this.hubContext.Clients.Group(model.EventCode)
                                 .SendAsync("Callback", q.Content, q.PublishedOn.ToShortDateString(), q.AuthorName, q.Id);

            return RedirectToAction("Join", new { code = model.EventCode });
        }
         
    }
}