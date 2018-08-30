using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vote.Tests.UnitTests.Services.Manager.Polls
{
    [TestClass]
    public class SetIsActivePollTests : BasePollTest
    {
        [TestMethod]
        public void WithInactivePoll_ReturnsActivePoll()
        {
            var pollId = 99;
            var eventId = 1;

            var isActiveBefore = this.db.Polls.Find(pollId).IsActive;

            this.service.SetIsActivePoll(pollId, eventId);

            var isActiveAfter = this.db.Polls.Find(pollId).IsActive;

            Assert.AreEqual(false, isActiveBefore);
            Assert.AreEqual(true, isActiveAfter);
        }

        [TestMethod]
        public void WithActivePoll_ReturnsActivePoll()
        {
            var pollId = 99;
            var eventId = 1;

            this.db.Polls.Find(pollId).IsActive = true;
            this.db.SaveChanges();

            var isActiveBefore = this.db.Polls.Find(pollId).IsActive;

            this.service.SetIsActivePoll(pollId, eventId);

            var isActiveAfter = this.db.Polls.Find(pollId).IsActive;

            Assert.AreEqual(true, isActiveBefore);
            Assert.AreEqual(true, isActiveAfter);
        }

        [TestMethod]
        public void WithSpecialId_ReturnsAllPollsDeactivated()
        {
            var pollId1 = 99;
            var pollId2 = 100;
            var eventId = 1;
            var deactivatorId = -1;

            this.db.Polls.Find(pollId1).IsActive = true;
            this.db.Polls.Find(pollId2).IsActive = true;
            this.db.SaveChanges();

            this.service.SetIsActivePoll(deactivatorId, eventId);

            var isActivePoll1 = this.db.Polls.Find(pollId1).IsActive;
            var isActivePoll2 = this.db.Polls.Find(pollId2).IsActive;

            Assert.AreEqual(false, isActivePoll1);
            Assert.AreEqual(false, isActivePoll2);
        }
    }
}