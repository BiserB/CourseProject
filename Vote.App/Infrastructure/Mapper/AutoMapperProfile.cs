using AutoMapper;
using Vote.Entities;
using Vote.Entities.Dtos;

namespace Vote.App.Infrastructure.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMap<EventDto, Event>();

            this.CreateMap<QuestionDto, Question>();

            this.CreateMap<ReplyDto, Reply>();

            this.CreateMap<PollDto, Poll>();

            this.CreateMap<PollQuestionDto, PollQuestion>();

            this.CreateMap<PollAnswerDto, PollAnswer>();
        }
    }
}