using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Vote.Common.BindingModels;
using Vote.Common.ViewModels.Events;

namespace Vote.Services.Manager.Interfaces
{
    public interface IManagerActivitiesService
    {
        EventFullModel GetEventFullModel(int id);

        AllEventsModel GetAllEventsForUser(string userId);

        void CreateEvent(CreateEventBindingModel model, string userId);

        CreateEventBindingModel GetEventModel();

        bool DeleteEvent(int id, string userId);
    }
}
