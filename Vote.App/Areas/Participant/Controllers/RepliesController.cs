using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using Vote.App.Infrastructure.Hubs;
using Vote.Common.BindingModels;
using Vote.Services.Participant.Interfaces;

namespace Vote.App.Areas.Participant.Controllers
{
    public class RepliesController : BaseParticipantController
    {
        private IParticipantRepliesService service;
        private IHubContext<VoteHub> hubContext;

        public RepliesController(IParticipantRepliesService service, IHubContext<VoteHub> hubContext)
        {
            this.service = service;
            this.hubContext = hubContext;
        }

        [HttpPost]
        public async Task<IActionResult> Post(ReplyBindingModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return RedirectToAction("Join", "Events", new { code = model.EventCode });
            }

            var saved = this.service.SaveReply(model);

            if (!saved)
            {
                return RedirectToAction("Join", "Events", new { code = model.EventCode });
            }

            await this.hubContext.Clients.Group(model.EventCode)
               .SendAsync("AddReply", new { model.QuestionId, model.ReplyContent, model.ReplyAuthor });

            return RedirectToAction("Join", "Events", new { code = model.EventCode });
        }
    }
}