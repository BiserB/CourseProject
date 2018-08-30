using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vote.Common.BindingModels;
using Vote.Data;
using Vote.Services.Manager;

namespace Vote.Tests.UnitTests.Services.Manager.Settings
{
    [TestClass]
    public class GetEventSetupModelTests
    {
        private VoteDbContext db;
        private IMapper mapper;
        private ManagerSettingsService service;

        [TestMethod]
        public void FromDbEvent_ReturnsModel()
        {
            int eventId = 1;
            string userId = "ABC";

            var model = this.service.GetEventSetupModel(eventId, userId);

            Assert.AreEqual(typeof(EventSetupModel), model.GetType());
        }

        [TestMethod]
        public void FromDeletedDbEvent_ReturnsNull()
        {
            var dbEvent = this.db.Events.Find(1);
            dbEvent.IsDeleted = true;
            this.db.SaveChanges();

            int eventId = 1;
            string userId = "ABC";

            var model = this.service.GetEventSetupModel(eventId, userId);

            Assert.AreEqual(null, model);
        }

        [TestInitialize]
        public void InitializeTests()
        {
            this.db = MockDbContext.GetTestDb();
            this.mapper = MockAutoMapper.GetAutoMapper();
            this.service = new ManagerSettingsService(this.db, this.mapper);
        }
    }
}