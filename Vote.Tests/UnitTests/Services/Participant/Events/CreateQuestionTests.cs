using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vote.Common.BindingModels;
using Vote.Entities;

namespace Vote.Tests.UnitTests.Services.Participant.Events
{
    [TestClass]
    public class CreateQuestionTests : BaseParticipantEventsTest
    {
        [TestMethod]
        public void WithValidModelReturnsQuestion()
        {
            var question = new QuestionBindingModel() { Content = "Test question" };

            var model = new JoinEventViewModel() { EventId = 1, Question = question };

            var result = this.service.CreateQuestion(model);

            Assert.AreEqual(typeof(Question), result.GetType());
        }
    }
}