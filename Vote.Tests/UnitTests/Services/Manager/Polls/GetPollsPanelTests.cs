using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vote.Common.ViewModels.Polls;

namespace Vote.Tests.UnitTests.Services.Manager.Polls
{
    [TestClass]
    public class GetPollsPanelTests : BasePollTest
    {
        [TestMethod]
        public void WithValidPolls_ReturnsPollPanelModel()
        {
            var eventId = 1;

            var model = this.service.GetPollsPanel(eventId);

            Assert.AreEqual(typeof(PollPanelModel), model.GetType());
        }

        [TestMethod]
        public void WithEventWith2Polls_ReturnsPollPanelModelWith2Polls()
        {
            var eventId = 1;

            var model = this.service.GetPollsPanel(eventId);

            var pollsCnt = model.Polls.Count;

            Assert.AreEqual(2, pollsCnt);
        }

        [TestMethod]
        public void WithEventWithoutPolls_ReturnsPollPanelModelWithoutPolls()
        {
            var eventId = 3;

            var model = this.service.GetPollsPanel(eventId);

            var pollsCnt = model.Polls.Count;

            Assert.AreEqual(0, pollsCnt);
        }
    }
}