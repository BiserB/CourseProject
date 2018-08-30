using AutoMapper;
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
    public class RestoreTests
    {
        private VoteDbContext db;
        private IMapper mapper;
        private ManagerQuestionsService service;

        [TestMethod]
        public void ArchivedQuestion_ReturnsNotArchivedQuestion()
        {
            var id = 1;

            var questionsArchived = this.db.Questions
                .Where(q => q.Id == id && q.IsArchived == true).Count();

            this.service.Restore(id);

            var questionsRestored = this.db.Questions
                .Where(q => q.Id == id && q.IsArchived == false).Count();

            Assert.AreEqual(1, questionsArchived);
            Assert.AreEqual(1, questionsRestored);
        }

        
        [TestInitialize]
        public void InitializeTests()
        {
            this.db = MockDbContext.GetTestDb();
            this.mapper = MockAutoMapper.GetAutoMapper();

            var question = new Question()
            {
                Id = 1,
                AuthorName = "Pesho",
                EventId = 1,
                IsArchived = true
            };

            this.db.Questions.Add(question);

            this.db.SaveChanges();

            this.service = new ManagerQuestionsService(this.db, this.mapper);
        }
    }
}
