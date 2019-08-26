using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vote.Common.ViewModels.Events;
using Vote.Data;
using Vote.Services.Manager;

namespace Vote.Tests.UnitTests.Services.Manager.Activities
{
    [TestClass]
    public class GetEventFullModelTests
    {
        private VoteDbContext db;
        private IMapper mapper;
        private ManagerActivitiesService service;

        [TestMethod]
        public void ReturnsEventFullModel()
        {
            var userId = "ABC";

            var model = this.service.GetEventFullModel(1, userId);

            Assert.AreEqual(typeof(EventFullModel), model.GetType());
        }

        [TestInitialize]
        public void InitializeTests()
        {
            this.db = MockDbContext.GetTestDb();
            this.mapper = MockAutoMapper.GetAutoMapper();
            this.service = new ManagerActivitiesService(this.db, this.mapper);
        }
    }
}