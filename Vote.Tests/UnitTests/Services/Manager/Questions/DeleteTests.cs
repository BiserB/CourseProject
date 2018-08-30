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
    public class DeleteTests
    {
        private VoteDbContext db;
        private ManagerQuestionsService service;

        [TestMethod]
        public void FromDbWithQuestionReturnNullQuestions()
        {
            var id = 1;
            var eventId = 1;
            var userId = "ABC";

            var questionsBefore = this.db.Questions
                .Where(q => q.Id == id && q.IsDeleted == false).Count();

            this.service.Delete(id, eventId, userId);

            var questionsAfter = this.db.Questions
                .Where(q => q.Id == id && q.IsDeleted == false).Count();

            Assert.AreEqual(1, questionsBefore);
            Assert.AreEqual(0, questionsAfter);
        }

        [TestMethod]
        public void FromDbWithWrongIdReturnFalse()
        {
            var id = 1001;
            var eventId = 1;
            var userId = "ABC";
            
            var isDeleted = this.service.Delete(id, eventId, userId);

            Assert.AreEqual(false, isDeleted);
        }

        [TestMethod]
        public void FromDbWithWrongEventIdReturnFalse()
        {
            var id = 1;
            var eventId = 1001;
            var userId = "ABC";

            var isDeleted = this.service.Delete(id, eventId, userId);

            Assert.AreEqual(false, isDeleted);
        }

        [TestMethod]
        public void FromDbWithWrongUserIdReturnFalse()
        {
            var id = 1;
            var eventId = 1001;
            var userId = "Pesho";

            var isDeleted = this.service.Delete(id, eventId, userId);

            Assert.AreEqual(false, isDeleted);
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
