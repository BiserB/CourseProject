using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vote.Common.BindingModels;
using Vote.Data;
using Vote.Services.Manager;

namespace Vote.Tests.UnitTests.Services.Manager.Activities
{
    [TestClass]
    public class CreateEventTests
    {
        private VoteDbContext emptyDb;
        private IMapper mapper;
        private ManagerActivitiesService service;

        [TestMethod]
        public void WithEmptyDb_ReturnsOneEvent()
        {
            var model = new CreateEventBindingModel()
            {
                Code = "1111",
                Title = "Test",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
            };

            string userId = "ABC";

            this.service.CreateEvent(model, userId);

            var db = this.emptyDb;

            var dbEvents = this.emptyDb.Events.ToList();

            Assert.AreEqual(1, dbEvents.Count);
        }
        
        [TestInitialize]
        public void InitializeTests()
        {
            this.mapper = MockAutoMapper.GetAutoMapper();
            this.emptyDb = MockDbContext.GetEmptyTestDb();
            this.service = new ManagerActivitiesService(this.emptyDb, this.mapper);
        }
    }
}
