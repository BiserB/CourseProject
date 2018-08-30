using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vote.Common;
using Vote.Common.BindingModels;
using Vote.Data;
using Vote.Entities;
using Vote.Services.Participant.Interfaces;

namespace Vote.Services.Participant
{
    public class ParticipantRepliesService : BaseParticipantService , IParticipantRepliesService
    {
        public ParticipantRepliesService(VoteDbContext db, IMapper mapper)
            :base(db, mapper)
        {

        }

        public bool SaveReply(ReplyBindingModel model)
        {
            var isPermitted = this.db.Questions
                                     .Any(q => q.Id == model.QuestionId && q.EventId == model.EventId &&
                                               q.Event.IsClosed == false && q.Event.IsDeleted == false);

            if (!isPermitted)
            {
                return false;
            }

            var reply = new Reply()
            {
                QuestionId = model.QuestionId,
                Content = model.ReplyContent
            };

            if (model.ReplyAuthor == null)
            {
                reply.AuthorName = VoteConstants.Anonymous;
            }
            else
            {
                reply.AuthorName = model.ReplyAuthor;
            }

            this.db.Replies.Add(reply);

            this.db.SaveChanges();

            return true;
        }
    }
}
