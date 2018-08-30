using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vote.Common.BindingModels;
using Vote.Data;
using Vote.Services.Manager;

namespace Vote.Tests.UnitTests.Services.Manager.Activities
{
    [TestClass]
    public class GetEventModelTests
    {
        private VoteDbContext emptyDb;
        private ManagerActivitiesService service;

        [TestMethod]
        public void ReturnsObjectEventBindingModel()
        {
            var model = this.service.GetEventModel();

            Assert.AreEqual(typeof(CreateEventBindingModel), model.GetType());
        }

        [TestInitialize]
        public void InitializeTests()
        {
            this.emptyDb = MockDbContext.GetEmptyTestDb();
            this.service = new ManagerActivitiesService(this.emptyDb, null);
        }
    }
}