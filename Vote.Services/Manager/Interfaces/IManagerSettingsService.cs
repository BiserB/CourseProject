using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Vote.Common.BindingModels;
using Vote.Entities;

namespace Vote.Services.Manager.Interfaces
{
    public interface IManagerSettingsService
    {
        EventSetupModel GetEventSetupModel(int eventId, string userId);

        Event GetEvent(EventSetupModel model, string userId);

        bool SaveEventChanges(EventSetupModel model, Event dbEvent);

        Task<bool> UploadLogo(IFormFile file, string userId);
    }
}