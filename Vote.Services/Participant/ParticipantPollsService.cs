using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using Vote.Common.BindingModels;
using Vote.Common.ViewModels.Polls;
using Vote.Data;

using Vote.Services.Participant.Interfaces;

namespace Vote.Services.Participant
{
    public class ParticipantPollsService : BaseParticipantService, IParticipantPollsService
    {
        public ParticipantPollsService(VoteDbContext db, IMapper mapper)
            : base(db, mapper)
        {
        }

        public List<PollResultModel> GetPollResults(int id)
        {
            var polls = this.db.Polls.Where(p => p.Id == id && p.IsDeleted == false)
                                     .Select(p => new PollResultModel()
                                     {
                                         PollQuestion = p.PollQuestion.Content,
                                         PollAnswers = p.PollAnswers
                                                        .Select(pa => new PollAnswerInfoModel()
                                                        {
                                                            Content = pa.Content,
                                                            Votes = pa.Votes
                                                        }).ToList()
                                     }).ToList();

            return polls;
        }

        public ActivePollModel GetActivePoll(int id)
        {
            var activePoll = this.db.Polls
                                    .Where(p => p.EventId == id &&
                                                p.IsActive == true &&
                                                p.IsDeleted == false &&
                                                p.IsClosed == false)
                                     .Select(p => new ActivePollModel()
                                     {
                                         PollId = p.Id,
                                         EventCode = p.Event.Code,
                                         PollQuestion = p.PollQuestion.Content,
                                         PollAnswers = p.PollAnswers
                                                        .Select(pa => new SelectListItem()
                                                        {
                                                            Text = pa.Content,
                                                            Value = pa.Id.ToString()
                                                        }).ToList(),
                                     })
                                     .FirstOrDefault();

            return activePoll;
        }

        public bool AddVote(PollVoteModel model)
        {
            var dbEvent = this.GetDbEventByCode(model.EventCode);

            if (dbEvent == null)
            {
                return false;
            }

            if (!int.TryParse(model.Option, out int id))
            {
                return false;
            }

            var pollAnswer = this.db.PollAnswers
                .FirstOrDefault(pa => pa.Id == id && pa.PollId == model.PollId);

            if (pollAnswer == null)
            {
                return false;
            }

            pollAnswer.Votes += 1;

            this.db.SaveChanges();

            return true;
        }
    }
}