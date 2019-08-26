using Vote.Common.BindingModels;
using Vote.Common.ViewModels.Events;

namespace Vote.Services.Manager.Interfaces
{
    public interface IManagerActivitiesService
    {
        EventFullModel GetEventFullModel(int id, string userId);

        AllEventsModel GetAllEventsForUser(string userId);

        bool CreateEvent(CreateEventBindingModel model, string userId);

        CreateEventBindingModel GetEventModel();

        bool DeleteEvent(int id, string userId);
    }
}