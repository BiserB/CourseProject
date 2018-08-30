using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vote.Common.BindingModels;

namespace Vote.Tests.UnitTests.Services.Participant.Polls
{
    [TestClass]
    public class GetActivePollTests : BaseParticipantPollTest
    {
        [TestMethod]
        public void WithValidId_ReturnsActivePollModel()
        {
            this.db.Polls.Find(99).IsActive = true;

            this.db.SaveChanges();

            var eventId = 1;

            var result = this.service.GetActivePoll(eventId);

            Assert.AreEqual(typeof(ActivePollModel), result.GetType());
        }

        [TestMethod]
        public void WithNoActivePoll_ReturnsNull()
        {
            var eventId = 1;

            var result = this.service.GetActivePoll(eventId);

            Assert.AreEqual(null, result);
        }
    }
}