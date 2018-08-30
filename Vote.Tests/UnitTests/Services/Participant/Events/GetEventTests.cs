using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vote.Common.ViewModels.Events;

namespace Vote.Tests.UnitTests.Services.Participant.Events
{
    [TestClass]
    public class GetEventTests : BaseParticipantEventsTest
    {
        [TestMethod]
        public void WithValidCodeReturnsEventViewModel()
        {
            var code = "001";

            var result = this.service.GetEvent(code);

            Assert.AreEqual(typeof(EventViewModel), result.GetType());
        }
    }
}