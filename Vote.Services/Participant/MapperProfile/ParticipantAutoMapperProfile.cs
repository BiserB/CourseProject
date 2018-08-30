﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Vote.Common.BindingModels;
using Vote.Entities;

namespace Vote.Services.Participant.MapperProfile
{
    public class ParticipantAutoMapperProfile : Profile
    {
        public ParticipantAutoMapperProfile()
        {
            this.CreateMap<Event, JoinEventViewModel>();
        }
    }
}
