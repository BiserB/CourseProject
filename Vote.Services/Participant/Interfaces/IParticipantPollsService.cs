using System.Collections.Generic;
using Vote.Common.BindingModels;
using Vote.Common.ViewModels.Polls;

namespace Vote.Services.Participant.Interfaces
{
    public interface IParticipantPollsService
    {
        ActivePollModel GetActivePoll(int id);

        bool AddVote(PollVoteModel model);

        List<PollResultModel> GetPollResults(int id);
    }
}