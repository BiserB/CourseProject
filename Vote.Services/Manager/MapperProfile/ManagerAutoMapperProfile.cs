using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Vote.Common.BindingModels;
using Vote.Common.ViewModels.Events;
using Vote.Common.ViewModels.Polls;
using Vote.Entities;

namespace Vote.Services.Manager.MapperProfile
{
    public class ManagerAutoMapperProfile : Profile
    {
        public ManagerAutoMapperProfile()
        {
            this.CreateMap<CreateEventBindingModel, Event>()
                .ForMember(e => e.Id, opt => opt.Ignore())
                .ForMember(e => e.CreatorId, opt => opt.Ignore())
                .ForMember(e => e.Creator, opt => opt.Ignore())
                .ForMember(e => e.IsDeleted, opt => opt.Ignore())
                .ForMember(e => e.IsPrivate, opt => opt.Ignore())
                .ForMember(e => e.Polls, opt => opt.Ignore());

            this.CreateMap<Event, EventViewModel>();

            this.CreateMap<Event, EventSetupModel>().ReverseMap();

            this.CreateMap<Poll, PollViewModel>().ReverseMap();

            this.CreateMap<Poll, PollBindingModel>().ReverseMap();

            this.CreateMap<Event, EventInfoModel>();

            this.CreateMap<Event, EventFullModel>()
                .ForMember(e => e.EventCode, opt => opt.MapFrom(src => src.Code))
                .ForMember(e => e.ActiveQuestions, opt => opt.Ignore())
                .ForMember(e => e.ArchivedQuestions, opt => opt.Ignore());

            this.CreateMap<Reply, ReplyViewModel >();

            this.CreateMap<Question, RestoreQuestionModel>();

            this.CreateMap<EventInfoModel, PollPanelModel>()
                .ForMember(p => p.EventId, opt => opt.MapFrom(src => src.Id))
                .ForMember(p => p.EventCode, opt => opt.MapFrom(src => src.Code))
                .ForMember(p => p.EventTitle, opt => opt.MapFrom(src => src.Title))
                .ForMember(p => p.IsPastEvent, opt => opt.MapFrom(src => src.IsPastEvent));
        }
    }
}
