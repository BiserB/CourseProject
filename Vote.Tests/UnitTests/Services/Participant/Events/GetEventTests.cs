using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Vote.Data;
using Vote.Entities;
using Vote.Services.Participant;

namespace Vote.Tests.UnitTests.Services.Participant.Events
{
    [TestClass]
    public class GetEventTests : BaseParticipantEventsTest
    {
        [TestMethod]
        public void WithValidCodeReturnsEvent()
        {
            var code = "001";

            var result = this.service.GetEvent(code);

            Assert.AreEqual(typeof(Event), result.GetType());
        }
    }
}
