using Vote.Common.BindingModels;
using Vote.Common.ViewModels.Events;
using Vote.Entities;

namespace Vote.Services.Participant.Interfaces
{
    public interface IParticipantEventsService
    {
        EventViewModel GetEvent(string code);

        JoinEventViewModel CreateEventModel(EventViewModel dbEvent);

        Question CreateQuestion(JoinEventViewModel model);

        void SaveQuestion(Question question);

        QuestionViewModel GetQuestionModel(JoinEventViewModel model);

        void SetPublishedOn(JoinEventViewModel model);
    }
}