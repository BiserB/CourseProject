using AutoMapper;
using Vote.Common.BindingModels;
using Vote.Common.ViewModels.Events;
using Vote.Entities;

namespace Vote.Services.Participant.MapperProfile
{
    public class ParticipantAutoMapperProfile : Profile
    {
        public ParticipantAutoMapperProfile()
        {
            this.CreateMap<Event, JoinEventViewModel>();

            this.CreateMap<Event, EventViewModel>();
        }
    }
}