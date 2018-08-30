using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using Vote.App.Infrastructure.Hubs;
using Vote.Entities;
using Vote.Services.Manager.Interfaces;

namespace Vote.App.Areas.Manager.Controllers
{
    public class QuestionsController : BaseManagerController
    {
        private const string LocalUrl = "/home/index";
        private readonly IManagerQuestionsService service;
        private readonly IHubContext<VoteHub> hubContext;

        public QuestionsController(UserManager<User> userManager,
                                   IManagerQuestionsService service,
                                   IHubContext<VoteHub> hubContext)
                                  : base(userManager)
        {
            this.service = service;
            this.hubContext = hubContext;
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, int eventId, string EventCode)
        {
            if (!this.UserIsManager())
            {
                return LocalRedirect(LocalUrl);
            }

            var userId = await this.GetCurrentUserId();

            var isDeleted = this.service.Delete(id, eventId, userId);

            if (isDeleted)
            {
                await this.hubContext.Clients.Group(EventCode).SendAsync("DeleteQuestion", id);

                return RedirectToAction("Display", controllerName: "Activities", routeValues: new { Id = eventId });
            }

            return LocalRedirect(LocalUrl);
        }

        [HttpPost]
        public async Task<IActionResult> Archive(int id, int eventId, string EventCode)
        {
            var userId = await this.GetCurrentUserId();

            var isArchived = this.service.Archive(id, eventId, userId);

            if (isArchived)
            {
                await this.hubContext.Clients.Group(EventCode).SendAsync("DeleteQuestion", id);

                return RedirectToAction("Display", controllerName: "Activities", routeValues: new { Id = eventId });
            }

            return LocalRedirect(LocalUrl);
        }

        [HttpPost]
        public async Task<IActionResult> Restore(int id, int eventId, string EventCode)
        {
            var q = this.service.Restore(id);

            await this.hubContext.Clients.Group(EventCode)
                                 .SendAsync("Callback", q.Content, q.PublishedOn, q.AuthorName, q.Id);

            foreach (var reply in q.Replies)
            {
                await this.hubContext.Clients.Group(EventCode)
                                 .SendAsync("AddReply", new { questionId = q.Id, replyContent = reply.Content, replyAuthor = reply.AuthorName });
            }

            return RedirectToAction("Display", controllerName: "Activities", routeValues: new { Id = eventId });
        }
    }
}