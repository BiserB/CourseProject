using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Vote.Common.BindingModels;
using Vote.Common.ViewModels.Events;
using Vote.Entities;

namespace Vote.Services.Participant.Interfaces
{
    public interface IParticipantEventsService
    {
        Event GetEvent(string code);

        JoinEventViewModel CreateEventModel(Event dbEvent);

        Question CreateQuestion(JoinEventViewModel model);

        void SaveQuestion(Question question);

        QuestionViewModel GetQuestionModel(JoinEventViewModel model);

        void SetPublishedOn(JoinEventViewModel model);
    }
}
