using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using Vote.Common.BindingModels;
using Vote.Common.ViewModels.Events;
using Vote.Data;
using Vote.Entities;
using Vote.Services.Manager.Interfaces;

namespace Vote.Services.Manager
{
    public class ManagerActivitiesService : BaseManagerService, IManagerActivitiesService
    {
        public ManagerActivitiesService(VoteDbContext db,
                                        IMapper mapper)
                                 : base(db, mapper)
        {
        }

        public AllEventsModel GetAllEventsForUser(string userId)
        {
            var dbEvents = this.GetDbEvents(userId);

            var today = DateTime.Today;

            var activeEvents = dbEvents.Where(e => e.EndDate >= today).ToList();

            var pastEvents = dbEvents.Where(e => e.EndDate < today).ToList();

            var activeEventsList = this.mapper.Map<List<EventViewModel>>(activeEvents);

            var pastEventsList = this.mapper.Map<List<EventViewModel>>(pastEvents);

            var allEventsModel = new AllEventsModel()
            {
                ActiveEvents = activeEventsList,
                PastEvents = pastEventsList
            };

            return allEventsModel;
        }

        private List<Event> GetDbEvents(string userId)
        {
            var dbEvents = this.db.Events
                                  .Where(e => e.CreatorId == userId && e.IsDeleted == false)
                                  .ToList();
            return dbEvents;
        }

        public bool CreateEvent(CreateEventBindingModel model, string userId)
        {   
            var newEvent = this.mapper.Map<Event>(model);

            var codeIsOccupied = this.db.Events.Any(e => e.Code == model.Code && e.IsDeleted == false);

            if (codeIsOccupied)
            {
                return false;
            }

            newEvent.CreatorId = userId;
            
            this.db.Events.Add(newEvent);

            this.db.SaveChanges();

            return true;
        }

        public CreateEventBindingModel GetEventModel()
        {
            var eventModel = new CreateEventBindingModel()
            {
                Code = this.GetEventCode(),
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(7)
            };

            return eventModel;
        }

        public bool DeleteEvent(int id, string userId)
        {
            var eventToDelete = this.GetDbEvent(id, userId);

            if (eventToDelete == null)
            {
                return false;
            }

            eventToDelete.IsDeleted = true;

            this.db.SaveChanges();

            return true;
        }

        public EventFullModel GetEventFullModel(int id, string userId)
        {
            var dbEvent = this.GetDbEvent(id, userId);

            if (dbEvent == null)
            {
                return null;
            }
            
            var questions = this.db.Questions
                                   .Where(q => q.EventId == dbEvent.Id &&
                                               q.IsDeleted == false)
                                   .Select(q => new QuestionFullModel()
                                   {
                                       Id = q.Id,
                                       AuthorName = q.AuthorName,
                                       Content = q.Content,
                                       PublishedOn = q.PublishedOn.ToShortDateString(),
                                       EventId = dbEvent.Id,
                                       EventCode = dbEvent.Code,
                                       IsArchived = q.IsArchived,
                                       IsReviewed = q.IsReviewed,
                                       Upvotes = q.Upvotes,
                                       Doqwnvotes = q.Downvotes,
                                       Replies = q.Replies
                                                  .Select(r => new ReplyViewModel()
                                                  {
                                                      AuthorName = r.AuthorName,
                                                      Content = r.Content
                                                  }).ToList()
                                   })
                                   .ToList();

            var eventModel = this.mapper.Map<EventFullModel>(dbEvent);

            if (dbEvent.IsModerated)
            {
                eventModel.IncomingQuestions = questions.Where(q => q.IsArchived == false && q.IsReviewed == false).ToList();

                eventModel.ReviewedQuestions = questions.Where(q => q.IsArchived == false && q.IsReviewed == true).ToList();                
            }
            else
            {
                eventModel.IncomingQuestions = questions.Where(q => q.IsArchived == false).ToList();
            }

            eventModel.ArchivedQuestions = questions.Where(q => q.IsArchived == true).ToList();

            return eventModel;
        }
    }
}