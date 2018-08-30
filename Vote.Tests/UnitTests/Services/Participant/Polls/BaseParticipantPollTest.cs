using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vote.Data;
using Vote.Services.Participant;

namespace Vote.Tests.UnitTests.Services.Participant.Polls
{
    [TestClass]
    public abstract class BaseParticipantPollTest
    {
        protected VoteDbContext db;
        protected IMapper mapper;
        protected ParticipantPollsService service;

        [TestInitialize]
        public void InitializeTests()
        {
            this.mapper = MockAutoMapper.GetAutoMapper();
            this.db = MockDbContext.GetTestDbWithPollQuestions();
            this.service = new ParticipantPollsService(this.db, this.mapper);
        }
    }
}