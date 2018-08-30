using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Vote.Common.BindingModels;
using Vote.Data;
using Vote.Services.Manager;

namespace Vote.Tests.UnitTests.Services.Manager.Settings
{
    [TestClass]
    public class SaveEventChangesTests
    {
        private VoteDbContext db;
        private ManagerSettingsService service;

        [TestMethod]
        public void SaveValidModel_ReturnsTrue()
        {
            var existingEventModel = new EventSetupModel()
            {
                Id = 1,
                Code = "007",
                Title = "Seventh",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(7)
            };

            var userId = "ABC";

            var isSaved = this.service.SaveEventChanges(existingEventModel, userId);

            Assert.AreEqual(true, isSaved);
        }

        [TestMethod]
        public void FromValidModel_DbEventPropertiesAreChanged()
        {
            var dbEvent = this.db.Events.Find(1);

            var id = dbEvent.Id;
            var oldCode = dbEvent.Code;
            var oldTitle = dbEvent.Title;

            var existingEventModel = new EventSetupModel()
            {
                Id = 1,
                Code = "007",
                Title = "Seventh"
            };

            var userId = "ABC";

            this.service.SaveEventChanges(existingEventModel, userId);

            var savedEvent = this.db.Events.Find(1);

            Assert.AreEqual(id, savedEvent.Id);
            Assert.AreNotEqual(oldCode, savedEvent.Code);
            Assert.AreNotEqual(oldTitle, savedEvent.Title);
        }

        [TestInitialize]
        public void InitializeTests()
        {
            this.db = MockDbContext.GetTestDb();
            this.service = new ManagerSettingsService(this.db, null);
        }
    }
}