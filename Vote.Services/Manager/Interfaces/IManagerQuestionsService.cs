using System;
using System.Collections.Generic;
using System.Text;
using Vote.Common.ViewModels.Events;
using Vote.Entities;

namespace Vote.Services.Manager.Interfaces
{
    public interface IManagerQuestionsService
    {
        bool Delete(int id, int eventId, string userId);

        bool Archive(int id, int eventId, string userId);

        RestoreQuestionModel Restore(int id);

    }
}
