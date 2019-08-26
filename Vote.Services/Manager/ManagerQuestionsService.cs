using AutoMapper;
using System;
using System.Linq;
using Vote.Common.ViewModels.Events;
using Vote.Data;
using Vote.Services.Manager.Interfaces;

namespace Vote.Services.Manager
{
    public class ManagerQuestionsService : BaseManagerService, IManagerQuestionsService
    {
        public ManagerQuestionsService(VoteDbContext db, IMapper mapper)
            : base(db, mapper)
        {
        }

        public bool Delete(int id, int eventId, string userId)
        {
            var question = this.db.Questions
                .FirstOrDefault(q => q.Id == id && q.EventId == eventId);

            if (question == null)
            {
                return false;
            }

            var isAuthorized = this.db.Events.Any(e => e.Id == eventId && e.CreatorId == userId);

            if (!isAuthorized)
            {
                return false;
            }

            question.IsDeleted = true;

            this.db.SaveChanges();

            return true;
        }

        public bool Archive(int id, int eventId, string userId)
        {
            var question = this.db.Questions
                .FirstOrDefault(q => q.Id == id && q.EventId == eventId);

            if (question == null)
            {
                return false;
            }

            var isAuthorized = this.db.Events.Any(e => e.Id == eventId && e.CreatorId == userId);

            if (!isAuthorized)
            {
                return false;
            }

            question.IsArchived = true;

            this.db.SaveChanges();

            return true;
        }

        public RestoreQuestionModel Restore(int id)
        {
            var question = this.db.Questions.FirstOrDefault(q => q.Id == id);

            if (question == null)
            {
                throw new NullReferenceException();
            }

            question.IsArchived = false;

            this.db.SaveChanges();

            var replies = this.db.Replies.Where(r => r.QuestionId == id)
                                           .Select(r => new ReplyViewModel()
                                           {
                                               Content = r.Content,
                                               AuthorName = r.AuthorName
                                           })
                                           .ToList();

            var restoreQuestionModel = this.mapper.Map<RestoreQuestionModel>(question);

            restoreQuestionModel.Replies = replies;

            return restoreQuestionModel;
        }

        public RestoreQuestionModel Review(int id, int eventId, string userId)
        {
            var question = this.db.Questions
                .FirstOrDefault(q => q.Id == id && q.EventId == eventId);

            if (question == null)
            {
                throw new NullReferenceException();
            }

            var isAuthorized = this.db.Events.Any(e => e.Id == eventId && e.CreatorId == userId);

            if (!isAuthorized)
            {
                throw new NullReferenceException();
            }

            question.IsReviewed = true;

            this.db.SaveChanges();

            var replies = this.db.Replies.Where(r => r.QuestionId == id)
                                           .Select(r => new ReplyViewModel()
                                           {
                                               Content = r.Content,
                                               AuthorName = r.AuthorName
                                           })
                                           .ToList();

            var reviewedQuestion = this.mapper.Map<RestoreQuestionModel>(question);

            reviewedQuestion.Replies = replies;

            return reviewedQuestion;
        }
    }
}