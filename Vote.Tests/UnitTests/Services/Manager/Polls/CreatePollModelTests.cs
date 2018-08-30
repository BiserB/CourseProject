using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Vote.Common.BindingModels;
using Vote.Data;
using Vote.Services.Manager;

namespace Vote.Tests.UnitTests.Services.Manager.Polls
{
    [TestClass]
    public class CreatePollModelTests
    {
        private VoteDbContext db;
        private IMapper mapper;
        private ManagerPollsService service;

        [TestMethod]
        public void ReturnsPollBindingModel()
        {
            var eventId = 1;

            var model = this.service.CreatePollModel(eventId);

            Assert.AreEqual(typeof(PollBindingModel), model.GetType());
        }

        [TestMethod]
        public void WithInvalidEventIdThrowsNullReferenceException()
        {
            var eventId = 101;

            Assert.ThrowsException<NullReferenceException>(() => this.service.CreatePollModel(eventId));
        }

        [TestInitialize]
        public void InitializeTests()
        {
            this.mapper = MockAutoMapper.GetAutoMapper();
            this.db = MockDbContext.GetTestDb();
            this.service = new ManagerPollsService(this.db, this.mapper);
        }
    }
}