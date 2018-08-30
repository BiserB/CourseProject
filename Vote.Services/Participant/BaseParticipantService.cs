using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vote.Data;
using Vote.Entities;

namespace Vote.Services.Participant
{
    public abstract class BaseParticipantService
    {
        protected readonly VoteDbContext db;       
        protected readonly IMapper mapper;

        public BaseParticipantService(VoteDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        protected Event GetDbEventByCode(string code)
        {
            var today = DateTime.Today;

            var dbEvent = this.db.Events.FirstOrDefault(e => e.Code == code &&
                                                             e.EndDate >= today &&
                                                             e.IsDeleted == false);

            return dbEvent;
        }
    }
}
