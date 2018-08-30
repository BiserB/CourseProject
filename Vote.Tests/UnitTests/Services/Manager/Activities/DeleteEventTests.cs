using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vote.Data;
using Vote.Services.Manager;

namespace Vote.Tests.UnitTests.Services.Manager.Activities
{
    [TestClass]
    public class DeleteEventTests
    {
        private VoteDbContext db;
        private ManagerActivitiesService service;

        [TestMethod]
        public void WithThreeNotDeletedEvents_ReturnsTwoNotDeletedEvents()
        {
            var id = 1;
            var userId = "ABC";

            this.service.DeleteEvent(id, userId);

            var dbEventsAfterDeletition = this.db.Events
                                                 .Where(e => e.IsDeleted == false)
                                                 .ToList();

            Assert.AreEqual(2, dbEventsAfterDeletition.Count);
        }

        [TestMethod]
        public void WithThreeEventsAndValidUserId_ReturnsTrue()
        {
            var id = 1;
            var userId = "ABC";

            var isDeleted = this.service.DeleteEvent(id, userId);
                        
            Assert.AreEqual(true, isDeleted);
        }

        [TestMethod]
        public void WithThreeEventsAndInvalidUserId_ReturnsFalse()
        {
            var id = 1;
            var userId = "FakeUserId";

            var isDeleted = this.service.DeleteEvent(id, userId);

            Assert.AreEqual(false, isDeleted);
        }

        [TestMethod]
        public void WithThreeEventsAndInvalidId_ReturnsFalse()
        {
            var id = 101;
            var userId = "ABC";

            var isDeleted = this.service.DeleteEvent(id, userId);

            Assert.AreEqual(false, isDeleted);
        }

        [TestInitialize]
        public void InitializeTests()
        {
            this.db = MockDbContext.GetTestDb();
            this.service = new ManagerActivitiesService(this.db, null);
        }
    }
}
