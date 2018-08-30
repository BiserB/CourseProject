using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Vote.Data;
using Vote.Entities;
using Vote.Services.Manager;

namespace Vote.Tests.UnitTests.Services.Manager.Polls
{
    [TestClass]
    public abstract class BasePollTest
    {
        protected VoteDbContext db;
        protected IMapper mapper;
        protected ManagerPollsService service;

        [TestInitialize]
        public void InitializeTests()
        {
            this.mapper = MockAutoMapper.GetAutoMapper();
            this.db = MockDbContext.GetTestDb();
            this.service = new ManagerPollsService(this.db, this.mapper);

            var testPollQuestion = new PollQuestion() { Id = 1, Content = "Are you ready?" };

            var testPollAnswers = new List<PollAnswer>()
            {
                new PollAnswer(){ Id = 1, Content = "Yes"},
                new PollAnswer(){ Id = 2, Content = "No"}
            };

            var testPoll = new Poll()
            {
                Id = 99,
                EventId = 1,
                PollQuestion = testPollQuestion,
                PollAnswers = testPollAnswers,
                IsDeleted = false,
                IsActive = false
            };

            var testPollQuestion2 = new PollQuestion() { Id = 2, Content = "Are you ready again?" };

            var testPollAnswers2 = new List<PollAnswer>()
            {
                new PollAnswer(){ Id = 3, Content = "Yes"},
                new PollAnswer(){ Id = 4, Content = "No"}
            };

            var testPoll2 = new Poll()
            {
                Id = 100,
                EventId = 1,
                PollQuestion = testPollQuestion2,
                PollAnswers = testPollAnswers2,
                IsDeleted = false,
                IsActive = false
            };

            db.Polls.AddRange(testPoll, testPoll2);
            db.SaveChanges();
        }
    }
}