using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vote.Common.BindingModels;
using Vote.Data;
using Vote.Entities;
using Vote.Services.Participant;

namespace Vote.Tests.UnitTests.Services.Participant.Replies
{
    [TestClass]
    public class SaveReplyTests
    {
        protected VoteDbContext db;
        protected IMapper mapper;
        protected ParticipantRepliesService service;

        [TestMethod]
        public void WithValidModel_ReplyIsAdded()
        {
            var repliesBefore = this.db.Questions.Find(1).Replies.Count;

            var model = new ReplyBindingModel()
            {
                EventId = 1,
                EventCode = "001",
                QuestionId = 1,
                ReplyContent = "My reply"
            };

            this.service.SaveReply(model);

            var repliesAfter = this.db.Questions.Find(1).Replies.Count;

            Assert.AreEqual(0, repliesBefore);
            Assert.AreEqual(1, repliesAfter);
        }

        [TestMethod]
        public void WithValidModelAndWrongQuestionId_ReturnsFalse()
        {
            var model = new ReplyBindingModel()
            {
                QuestionId = 101,
                ReplyContent = "My reply"
            };

            var result = this.service.SaveReply(model);

            Assert.AreEqual(false, result);
        }

        [TestInitialize]
        public void InitializeTests()
        {
            this.mapper = MockAutoMapper.GetAutoMapper();
            this.db = MockDbContext.GetTestDb();
            this.service = new ParticipantRepliesService(this.db, this.mapper);

            var testQuestion = new Question() { Id = 1, Content = "First test", EventId = 1 };

            db.Questions.Add(testQuestion);

            db.SaveChanges();
        }
    }
}