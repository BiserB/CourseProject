using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Vote.App.Infrastructure.Session;
using Vote.Common;
using Vote.Common.BindingModels;
using Vote.Common.ViewModels.Polls;
using Vote.Services.Participant.Interfaces;

namespace Vote.App.Areas.Participant.Controllers
{
    public class PollsController : BaseParticipantController
    {
        private readonly IParticipantPollsService service;

        public PollsController(IParticipantPollsService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult Vote(int id, string code)
        {
            var pollModel = this.service.GetActivePoll(id);

            if (pollModel == null)
            {
                return RedirectToAction("PollResults", new { id = 0, code});
            }

            var votedInPoll = this.HttpContext.Session.VotedInPoll(pollModel.PollId.ToString());

            if (votedInPoll)
            {
                return RedirectToAction("PollResults", new { id = pollModel.PollId, code});
            }            

            return this.View(pollModel);
        }

        [HttpPost]
        public IActionResult Vote(PollVoteModel model)
        {
            if (this.ModelState.IsValid)
            {
                var voted = this.service.AddVote(model);

                if (voted)
                {
                    string pollId = model.PollId.ToString();

                    this.HttpContext.Session.SetPollId(pollId, VoteConstants.Voted);
                }
            }            

            return RedirectToAction("PollResults", new { id = model.PollId, code = model.EventCode });
        }

        [HttpGet]
        public IActionResult PollResults(int id, string code)
        {
            ViewData["BackUrl"] = code;

            if (id == 0)
            {
                return this.View(new List<PollResultModel>());
            }
            
            var pollResultsModel = this.service.GetPollResults(id);            

            return this.View(pollResultsModel);
        }
    }
}