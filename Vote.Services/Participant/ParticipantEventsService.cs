using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using Vote.Common;
using Vote.Common.BindingModels;
using Vote.Common.ViewModels.Events;
using Vote.Data;
using Vote.Entities;
using Vote.Services.Participant.Interfaces;

namespace Vote.Services.Participant
{
    public class ParticipantEventsService : BaseParticipantService, IParticipantEventsService
    {
        public ParticipantEventsService(VoteDbContext db,
                                        IMapper mapper)
                                        : base(db, mapper)
        {
        }

        public EventViewModel GetEvent(string code)
        {
            return this.GetDbEventByCode(code);
        }

        public JoinEventViewModel CreateEventModel(EventViewModel eventModel)
        {
            var questions = new List<QuestionFullModel>();

            if (eventModel.IsModerated)
            {
                questions = this.db.Questions
                                  .Where(q => q.EventId == eventModel.Id &&
                                              q.IsReviewed == true &&
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
                                                     Content = r.Content
                                                 }).ToList()
                                  })
                                  .ToList();
            }
            else
            {
                questions = this.db.Questions
                                  .Where(q => q.EventId == eventModel.Id &&
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
                                                     Content = r.Content
                                                 }).ToList()
                                  })
                                  .ToList();
            }

            var creator = this.db.Users.Find(eventModel.CreatorId);

            string logoFileName = "DefaultLog.jpg";

            if (creator.HasLogo)
            {
                logoFileName = creator.Id + ".jpg";
            }

            var joinModel = new JoinEventViewModel()
            {
                EventId = eventModel.Id,
                EventCode = eventModel.Code,
                EventTitle = eventModel.Title,
                Questions = questions,
                LogoFileName = logoFileName
            };

            return joinModel;
        }

        public Question CreateQuestion(JoinEventViewModel model)
        {
            var dbEvent = this.db.Events.FirstOrDefault(e => e.Id == model.EventId &&
                                                  e.IsClosed == false &&
                                                  e.IsDeleted == false);

            if (dbEvent == null)
            {
                return null;
            }
            
            var question = new Question()
            {
                EventId = model.EventId,
                Content = model.Question.Content,
                PublishedOn = DateTime.Now
            };

            if (dbEvent.IsModerated)
            {
                question.IsReviewed = false;
            }
            else
            {
                question.IsReviewed = true;
            }

            if (model.Question.ParticipantName != null)
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