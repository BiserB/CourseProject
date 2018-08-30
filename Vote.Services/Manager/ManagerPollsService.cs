using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vote.Common.BindingModels;
using Vote.Common.ViewModels.Events;
using Vote.Common.ViewModels.Polls;
using Vote.Data;
using Vote.Entities;
using Vote.Services.Manager.Interfaces;

namespace Vote.Services.Manager
{
    public class ManagerPollsService : BaseManagerService, IManagerPollsService
    {
        public ManagerPollsService(VoteDbContext db, IMapper mapper)
            : base(db, mapper)
        {
        }

        public PollBindingModel CreatePollModel(int id)
        {
            var eventInfo = GetEventInfo(id);

            var pollModel = new PollBindingModel
            {
                EventId = eventInfo.Id,
                EventCode = eventInfo.Code,
                EventTitle = eventInfo.Title
            };

            return pollModel;
        }

        public async Task<bool> CreatePollAsync(PollBindingModel model, string userId)
        {
            var userIsAuthorized = this.db.Events
                .Any(e => e.Id == model.EventId && e.CreatorId == userId);

            if (!userIsAuthorized)
            {
                return false;
            }

            var pollQuestion = new PollQuestion() { Content = model.PollQuestion };

            var pollAnswers = new List<PollAnswer>();

            foreach (var answer in model.Answers)
            {
                pollAnswers.Add(new PollAnswer() { Content = answer });
            }

            var poll = new Poll()
            {
                EventId = model.EventId,
                PollQuestion = pollQuestion,
                PollAnswers = pollAnswers,
                CreatedOn = DateTime.Now,
            };

            this.db.Polls.Add(poll);

            await this.db.SaveChangesAsync();

            return true;
        }

        public PollPanelModel GetPollsPanel(int id)
        {
            var eventInfo = GetEventInfo(id);

            var polls = this.db.Polls
                               .Where(p => p.EventId == id && p.IsDeleted == false)
                               .Select(p => new PollViewModel
                               {
                                   Id = p.Id,
                                   PollQuestion = p.PollQuestion.Content,
                                   Votes = p.PollAnswers.Select(pa => pa.Votes).Sum(),
                                   CreatedOn = p.CreatedOn,
                                   IsActive = p.IsActive
                               })
                               .ToList();

            var pollPanelModel = this.mapper.Map<PollPanelModel>(eventInfo);

            pollPanelModel.Polls = polls;

            return pollPanelModel;
        }

        private EventInfoModel GetEventInfo(int id)
        {
            var dbEvent = this.db.Events
                .FirstOrDefault(e => e.Id == id && e.IsDeleted == false);

            if (dbEvent == null)
            {
                throw new NullReferenceException();
            }

            var eventInfo = this.mapper.Map<EventInfoModel>(dbEvent);

            eventInfo.IsPastEvent = dbEvent.EndDate < DateTime.Today;

            return eventInfo;
        }

        public PollDetailsModel GetPollDetails(int id)
        {
            var pollDetails = db.Polls
                                .Where(p => p.Id == id && p.IsDeleted == false)
                                .Select(p => new PollDetailsModel()
                                {
                                    Id = p.Id,
                                    EventId = p.EventId,
                                    EventTitle = p.Event.Title,
                                    PollQuestion = p.PollQuestion.Content,
                                    PollAnswers = p.PollAnswers.Select(pa => pa.Content).ToList(),
                                    CreatedOn = p.CreatedOn,
                                    IsActive = p.IsActive,
                                    IsClosed = p.IsClosed,
                                    IsDeleted = p.IsDeleted
                                })
                                .FirstOrDefault();

            return pollDetails;
        }

        public void SetIsActivePoll(int id, int eventId)
        {
            var polls = this.db.Polls.Where(p => p.EventId == eventId && p.IsDeleted == false).ToList();

            if (!polls.Any())
            {
                throw new NullReferenceException();
            }

            polls.ForEach(p => p.IsActive = false);

            if (id != -1)
            {
                var poll = polls.FirstOrDefault(p => p.Id == id && p.IsDeleted == false);

                if (poll == null)
                {
                    throw new NullReferenceException();
                }

                poll.IsActive = true;
            }

            this.db.SaveChanges();
        }

        public bool DeletePoll(int id, int eventId, string userId)
        {
            var userIsAuthorized = this.db.Events
                .Any(e => e.Id == eventId && e.CreatorId == userId);

            if (!userIsAuthorized)
            {
                return false;
            }

            var pollToDelete = this.db.Polls.FirstOrDefault(p => p.Id == id &&
                                                                 p.IsDeleted == false &&
                                                                 p.EventId == eventId);

            if (pollToDelete == null)
            {
                return false;
            }

            pollToDelete.IsDeleted = true;

            this.db.SaveChanges();

            return true;
        }
    }
}