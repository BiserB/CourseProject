using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Vote.Common.BindingModels;
using Vote.Common.ViewModels.Events;
using Vote.Data;
using Vote.Services.Participant;

namespace Vote.Tests.UnitTests.Services.Participant.Events
{
    [TestClass]
    public class CreateEventModelTests : BaseParticipantEventsTest
    {
        [TestMethod]
        public void ReturnsJoinEventViewModel()
        {
            var dbEvent = this.db.Events.Find(1);

            var eventModel = this.mapper.Map<EventViewModel>(dbEvent);

            var model = this.service.CreateEventModel(eventModel);

            Assert.AreEqual(typeof(JoinEventViewModel), model.GetType());
        }
    }
}
