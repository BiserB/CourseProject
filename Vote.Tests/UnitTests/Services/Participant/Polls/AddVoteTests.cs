using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Vote.Common.BindingModels;

namespace Vote.Tests.UnitTests.Services.Participant.Polls
{
    [TestClass]
    public class AddVoteTests : BaseParticipantPollTest
    {
        [TestMethod]
        public void WithValidModel_VoteAddedToSelectedAnswer()
        {
            var pollOptionId = 1;

            var votesBefore = this.db.PollAnswers.Find(pollOptionId).Votes;

            var model = new PollVoteModel() { PollId = 99, EventCode = "001" , Option = pollOptionId.ToString()};

            this.service.AddVote(model);

            var votesAfter = this.db.PollAnswers.Find(pollOptionId).Votes;

            Assert.AreEqual(0, votesBefore);
            Assert.AreEqual(1, votesAfter);
        }
    }
}
