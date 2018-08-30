using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vote.Common;
using Vote.Common.BindingModels;
using Vote.Common.ViewModels.Events;
using Vote.Data;
using Vote.Entities;
using Vote.Services.Participant.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Vote.Services.Participant
{
    public class ParticipantEventsService: BaseParticipantService, IParticipantEventsService
    {
        public ParticipantEventsService(VoteDbContext db,
                                        IMapper mapper)
                                        : base(db,  mapper)
        {

        }

        public Event GetEvent(string code)
        {
            var today = DateTime.Today;

            var dbEvent = this.db.Events
                              .FirstOrDefault(e => e.Code == code &&
                                                   e.EndDate >= today &&
                                                   e.IsDeleted == false);
            
            return dbEvent;
        }

        public JoinEventViewModel CreateEventModel(Event dbEvent)
        {
            var questions = this.db.Questions
                                   .Where(q => q.EventId == dbEvent.Id &&
                                               q.IsArchived == false &&
                                               q.IsDeleted == false)                                   
                                   .Select(q => new QuestionFullModel()
                                   {
                                       Id = q.Id,
                                       AuthorName = q.AuthorName,
                                       Content = q.Content,
                                       Upvotes = q.Upvotes,
                                       PublishedOn = q.PublishedOn.ToShortDateString(),
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

            var joinModel = new JoinEventViewModel()
            {
                EventId = dbEvent.Id,
                EventCode = dbEvent.Code,
                EventTitle = dbEvent.Title
            };

            joinModel.Questions = questions;                                   

            return joinModel;
        }

        public Question CreateQuestion(JoinEventViewModel model)
        {
            var question = new Question()
            {
                EventId = model.EventId,
                Content = model.Question.Content,
                PublishedOn = DateTime.Now
            };

            bool isNotAnonymous = model.Question.ParticipantName != VoteConstants.Anonymous;

            if (isNotAnonymous)
            {
                question.AuthorName = model.Question.ParticipantName;
            }
            else
            {
                question.AuthorName = VoteConstants.Anonymous;
            }
            
            return question;
        }

        public void SetPublishedOn(JoinEventViewModel model)
        {
            model.Question.PublishedOn = DateTime.Now;
        }

        public void SaveQuestion(Question question)
        {      
            this.db.Questions.Add(question);

            this.db.SaveChanges();
        }

        public QuestionViewModel GetQuestionModel(JoinEventViewModel model)
        {
            var questionModel = new QuestionViewModel()
            {
                AuthorName = model.Question.ParticipantName,
                PublishedOn = model.Question.PublishedOn,
                Content = model.Question.Content
            };

            return questionModel;
        } 
    }
}
