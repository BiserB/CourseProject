using System.Threading.Tasks;
using Vote.Common.BindingModels;

using Vote.Common.ViewModels.Polls;

namespace Vote.Services.Manager.Interfaces
{
    public interface IManagerPollsService
    {
        PollPanelModel GetPollsPanel(int id);

        Task<bool> CreatePollAsync(PollBindingModel model, string userId);

        PollBindingModel CreatePollModel(int id);

        PollDetailsModel GetPollDetails(int id);

        void SetIsActivePoll(int id, int eventId);

        bool DeletePoll(int id, int eventId, string userId);
    }
}