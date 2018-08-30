using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Vote.Common.ViewModels.Polls;

namespace Vote.Tests.UnitTests.Services.Participant.Polls
{
    [TestClass]
    public class GetPollResults : BaseParticipantPollTest
    {
        [TestMethod]
        public void WithValidId_ReturnsListOfPollResultModel()
        {
            var pollId = 99;

            var result = this.service.GetPollResults(pollId);

            Assert.AreEqual(typeof(List<PollResultModel>), result.GetType());
        }

        [TestMethod]
        public void WithDeletedPoll_ReturnsEmptyListOfPollResultModel()
        {
            var pollId = 99;

            this.db.Polls.Find(pollId).IsDeleted = true;
            this.db.SaveChanges();

            var result = this.service.GetPollResults(pollId);

            Assert.AreEqual(0, result.Count);
        }
    }
}