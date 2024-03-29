﻿using AutoMapper;
using System;
using System.Linq;
using Vote.Common.ViewModels.Events;
using Vote.Data;

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

        protected EventViewModel GetDbEventByCode(string code)
        {    
            var dbEvent = this.db.Events.FirstOrDefault(e => e.Code == code && e.IsDeleted == false);

            if (dbEvent == null)
            {
                return null;
            }
                       
            var model = this.mapper.Map<EventViewModel>(dbEvent);

            return model;
        }
    }
}