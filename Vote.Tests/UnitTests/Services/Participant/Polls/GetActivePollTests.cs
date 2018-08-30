using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Vote.Common.BindingModels;
using Vote.Data;
using Vote.Entities;
using Vote.Services.Participant;

namespace Vote.Tests.UnitTests.Services.Participant.Polls
{
    [TestClass]
    public class GetActivePollTests : BaseParticipantPollTest
    {
        [TestMethod]
        public void WithValidId_ReturnsActivePollModel()
        {
            this.db.Polls.Find(99).IsActive = true;

            this.db.SaveChanges();

            var eventId = 1;

            var result = this.service.GetActivePoll(eventId);

            Assert.AreEqual(typeof(ActivePollModel), result.GetType());
        }

        [TestMethod]
        public void WithNoActivePoll_ReturnsNull()
        {
            var eventId = 1;

            var result = this.service.GetActivePoll(eventId);

            Assert.AreEqual(null, result);
        }
    }
}
