using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Vote.Common.BindingModels;

namespace Vote.Services.Manager.Interfaces
{
    public interface IManagerSettingsService
    {
        EventSetupModel GetEventSetupModel(int eventId, string userId);

        bool SaveEventChanges(EventSetupModel model, string userId);
    }
}
