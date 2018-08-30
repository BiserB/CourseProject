using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Vote.Data;
using Vote.Entities;

namespace Vote.Tests.UnitTests
{
    public static class MockDbContext
    {
        public static VoteDbContext GetEmptyTestDb()
        {
            var options = new DbContextOptionsBuilder<VoteDbContext>()
                            .UseInMemoryDatabase(Guid.NewGuid().ToString())
                            .EnableSensitiveDataLogging()
                            .Options;

            var db = new VoteDbContext(options);

            return db;
        }

        public static VoteDbContext GetTestDb()
        {
            var options = new DbContextOptionsBuilder<VoteDbContext>()
                            .UseInMemoryDatabase(Guid.NewGuid().ToString())
                            .Options;

            var db = new VoteDbContext(options);

            var activities = new List<Event>()
            {
                new Event()
                {
                    Id = 1,
                    Code = "001",
                    Title = "First",
                    CreatorId = "ABC",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(3)
                },
                new Event()
                {
                    Id = 2,
                    Code = "002",
                    Title = "Second",
                    CreatorId = "ABC",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(3)
                },
                new Event()
                {
                    Id = 3,
                    Code = "003",
                    Title = "Third",
                    CreatorId = "ABC",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(3)
                }
            };

            db.AddRange(activities);

            db.SaveChanges();

            return db;
        }

        public static VoteDbContext GetTestDbWithPollQuestions()
        {
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

            var db = GetTestDb();

            db.Polls.AddRange(testPoll, testPoll2);
            db.SaveChanges();

            return db;
        }
    }
}