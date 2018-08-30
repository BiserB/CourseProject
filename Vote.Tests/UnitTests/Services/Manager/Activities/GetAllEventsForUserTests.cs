using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Vote.Data;
using Vote.Services.Manager;

namespace Vote.Tests.UnitTests.Services.Manager.Activities
{
    [TestClass]
    public class GetAllEventsForUserTests
    {
        private VoteDbContext db;
        private IMapper mapper;
        private ManagerActivitiesService service;

        [TestMethod]
        public void WithThreeActiveEvents_ReturnsAllThree()
        {   
            var dbEvents = service.GetAllEventsForUser("ABC");

            var activeEventsCount = dbEvents.ActiveEvents.Count;

            Assert.AreEqual(3, activeEventsCount);
        }

        [TestMethod]
        public void WithNullPastEvents_ReturnsZeroPast()
        {            
            var dbEvents = service.GetAllEventsForUser("ABC");

            var pastEventsCount = dbEvents.PastEvents.Count;

            Assert.AreEqual(0, pastEventsCount);
        }

        [TestMethod]
        public void ForUserWithoutEvents_ReturnsZeroEvents()
        {
            var dbEvents = service.GetAllEventsForUser("Zero");

            var activeEventsCount = dbEvents.ActiveEvents.Count;

            var pastEventsCount = dbEvents.PastEvents.Count;

            Assert.AreEqual(0, activeEventsCount);
            Assert.AreEqual(0, pastEventsCount);
        }

        [TestInitialize]
        public void InitializeTests()
        {
            this.mapper = MockAutoMapper.GetAutoMapper();
            this.db = MockDbContext.GetTestDb();
            this.service = new ManagerActivitiesService(this.db, this.mapper);
        }

    }
}
