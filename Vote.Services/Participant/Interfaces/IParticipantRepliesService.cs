using Vote.Common.BindingModels;

namespace Vote.Services.Participant.Interfaces
{
    public interface IParticipantRepliesService
    {
        bool SaveReply(ReplyBindingModel model);
    }
}