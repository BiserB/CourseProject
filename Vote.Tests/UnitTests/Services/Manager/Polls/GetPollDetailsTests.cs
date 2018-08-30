using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Vote.Common.ViewModels.Polls;
using Vote.Data;
using Vote.Entities;
using Vote.Services.Manager;

namespace Vote.Tests.UnitTests.Services.Manager.Polls
{
    [TestClass]
    public class GetPollDetailsTests : BasePollTest
    {        
        [TestMethod]
        public void WithValidPollId_ReturnsPollDetailsModel()
        { 
            var pollId = 99;

            var model = this.service.GetPollDetails(pollId);

            Assert.AreEqual(typeof(PollDetailsModel), model.GetType());
        }

        [TestMethod]
        public void WithInvalidPollId_ReturnsNull()
        {
            var pollId = 101;

            var model = this.service.GetPollDetails(pollId);

            Assert.AreEqual(null, model);
        }

        [TestMethod]
        public void WithValidIdButDeletedPoll_ReturnsNull()
        {
            this.db.Polls.Find(99).IsDeleted = true;
            this.db.SaveChanges();

            var pollId = 99;

            var model = this.service.GetPollDetails(pollId);

            Assert.AreEqual(null, model);
        }
    }
}
