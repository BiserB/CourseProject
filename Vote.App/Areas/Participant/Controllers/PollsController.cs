using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vote.Common;
using Vote.Common.BindingModels;
using Vote.Services.Participant.Interfaces;
using Vote.App.Infrastructure.Session;

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
        public IActionResult Vote(int id)
        {
            var votedInPoll = this.HttpContext.Session.VotedInPoll(id.ToString());

            if (votedInPoll)
            {
               return RedirectToAction("PollResults", new { id });
            }

            var pollModel = this.service.GetActivePoll(id);

            if (pollModel == null)
            {
                return LocalRedirect("~/NoResult");
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

            return RedirectToAction("PollResults", new { id = model.PollId });
        }

        [HttpGet]
        public IActionResult PollResults(int id)
        {
            var pollResultsModel = this.service.GetPollResults(id);

            return this.View(pollResultsModel);
        }
    }
}
