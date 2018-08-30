using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using Vote.App.Infrastructure.Hubs;
using Vote.Common.BindingModels;
using Vote.Services.Participant.Interfaces;

namespace Vote.App.Areas.Participant.Controllers
{
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IHubContext<VoteHub> hubContext;
        private readonly IParticipantEventsService service;

        public QuestionsController(IHubContext<VoteHub> hubContext, IParticipantEventsService service)
        {
            this.hubContext = hubContext;
            this.service = service;
        }

        [HttpPost("/questions")]
        public async Task QuestionsServer(JoinEventViewModel model)
        {
            this.service.SetPublishedOn(model);

            var question = this.service.CreateQuestion(model);

            this.service.SaveQuestion(question);

            var questionModel = this.service.GetQuestionModel(model);

            await this.hubContext.Clients.Group(model.EventCode).SendAsync("Callback", "Hello", "From server");

            //await this.hubContext.Clients.All.SendAsync("Callback", questionModel.Content, questionModel.AuthorName);

            return;
        }

        //public async void Notify()
        //{
        //    await this.hubContext.Clients.All.SendAsync("Callback", "Hello", "From server");

        //}

        //[HttpPost("/questions")]
        //public async Task QuestionsServer(JoinEventViewModel model)
        //{
        //    this.service.SetPublishedOn(model);

        //    var question = await this.service.CreateQuestionAsync(model);

        //    this.service.SaveQuestion(question);

        //    var questionModel = this.service.GetQuestionModel(model);

        //    await this.hubContext.Clients.All.SendAsync("Callback", questionModel.Content, questionModel.AuthorName);

        //    return;
        //}
    }
}