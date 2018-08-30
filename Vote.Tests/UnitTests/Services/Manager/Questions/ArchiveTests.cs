using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vote.Data;
using Vote.Entities;
using Vote.Services.Manager;

namespace Vote.Tests.UnitTests.Services.Manager.Questions
{
    [TestClass]
    public class ArchiveTests
    {
        private VoteDbContext db;
        private ManagerQuestionsService service;

        [TestMethod]
        public void NotArchivedQuestion_ReturnsArchivedQuestion()
        {
            var id = 1;
            var eventId = 1;
            var userId = "ABC";

            var questionsArchivedBefore = this.db.Questions
                .Where(q => q.Id == id && q.IsArchived == true).Count();

            this.service.Archive(id, eventId, userId);

            var questionsArchivedAfter = this.db.Questions
                .Where(q => q.Id == id && q.IsArchived == true).Count();

            Assert.AreEqual(0, questionsArchivedBefore);
            Assert.AreEqual(1, questionsArchivedAfter);
        }

        [TestMethod]
        public void QuestionWithWrongId_ReturnsFalse()
        {
            var id = 1001;
            var eventId = 1;
            var userId = "ABC";

            var isArchived = this.service.Archive(id, eventId, userId);

            Assert.AreEqual(false, isArchived);
        }

        [TestMethod]
        public void QuestionWithWrongEventId_ReturnsFalse()
        {
            var id = 1;
            var eventId = 1001;
            var userId = "ABC";

            var isArchived = this.service.Archive(id, eventId, userId);

            Assert.AreEqual(false, isArchived);
        }

        [TestMethod]
        public void QuestionWithWrongUserId_ReturnsFalse()
        {
            var id = 1;
            var eventId = 1;
            var userId = "Pesho";

            var isArchived = this.service.Archive(id, eventId, userId);

            Assert.AreEqual(false, isArchived);
        }

        [TestInitialize]
        public void InitializeTests()
        {
            this.db = MockDbContext.GetTestDb();

            var question = new Question()
            {
                Id = 1,
                AuthorName = "Pesho",
                EventId = 1
            };

            this.db.Questions.Add(question);

            this.db.SaveChanges();

            this.service = new ManagerQuestionsService(this.db, null);
        }
    }
}
