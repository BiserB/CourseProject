using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vote.Data;
using Vote.Services.Participant;

namespace Vote.Tests.UnitTests.Services.Participant.Events
{
    [TestClass]
    public abstract class BaseParticipantEventsTest
    {
        protected VoteDbContext db;
        protected IMapper mapper;
        protected ParticipantEventsService service;

        [TestInitialize]
        public void InitializeTests()
        {
            this.db = MockDbContext.GetTestDb();
            this.mapper = MockAutoMapper.GetAutoMapper();
            this.service = new ParticipantEventsService(this.db, this.mapper);
        }
    }
}