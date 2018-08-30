using Vote.Common.ViewModels.Events;

namespace Vote.Services.Manager.Interfaces
{
    public interface IManagerQuestionsService
    {
        bool Delete(int id, int eventId, string userId);

        bool Archive(int id, int eventId, string userId);

        RestoreQuestionModel Restore(int id);
    }
}