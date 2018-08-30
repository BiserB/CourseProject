using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vote.Common.BindingModels;
using Vote.Common.ViewModels.Events;

namespace Vote.Tests.UnitTests.Services.Participant.Events
{
    [TestClass]
    public class GetQuestionModelTests : BaseParticipantEventsTest
    {
        [TestMethod]
        public void WithValidModelReturnsQuestionViewModel()
        {
            var question = new QuestionBindingModel() { Content = "Test question" };

            var model = new JoinEventViewModel() { EventId = 1, Question = question };

            var result = this.service.GetQuestionModel(model);

            Assert.AreEqual(typeof(QuestionViewModel), result.GetType());
        }
    }
}