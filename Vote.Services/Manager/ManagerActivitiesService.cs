using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void CreateEvent(CreateEventBindingModel model, string userId)
        {
            var newEvent = this.mapper.Map<Event>(model);
            
            newEvent.CreatorId = userId;

            this.db.Events.Add(newEvent);

            this.db.SaveChanges();
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
            var eventToDelete = this.db.Events
                .FirstOrDefault(e => e.Id == id &&
                                     e.CreatorId == userId &&
                                     e.IsDeleted == false);

            if (eventToDelete == null)
            {
                return false;
            }

            eventToDelete.IsDeleted = true;

            this.db.SaveChanges();

            return true;
        }

        public EventFullModel GetEventFullModel(int id)
        {
            var dbEvent = this.GetDbEvent(id);

            var questions = this.db.Questions
                                   .Where(q => q.EventId == dbEvent.Id &&
                                               q.IsDeleted == false)
                                   .Select(q => new QuestionFullModel()
                                   {
                                       Id = q.Id,
                                       AuthorName = q.AuthorName,
                                       Content = q.Content,
                                       PublishedOn = q.PublishedOn.ToShortDateString(),
                                       IsArchived = q.IsArchived,
                                       Upvotes = q.Upvotes,                                       
                                       Doqwnvotes = q.Downvotes,
                                       Replies = q.Replies
                                                  .Select(r => new ReplyViewModel()
                                                  {
                                                      AuthorName = r.AuthorName,
                                                      Content = r.Content,
                                                      Upvotes = r.Upvotes,
                                                      Downvotes = r.Downvotes
                                                  }).ToList()
                                   })                                   
                                   .ToList();
            
            var eventModel = this.mapper.Map<EventFullModel>(dbEvent);

            eventModel.ActiveQuestions = questions.Where(q => q.IsArchived == false).ToList();
            eventModel.ArchivedQuestions = questions.Where(q => q.IsArchived == true).ToList();

            return eventModel;
        }

    }
}
