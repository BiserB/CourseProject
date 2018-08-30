using System;
using System.Collections.Generic;

namespace Vote.Common.ViewModels.Polls
{
    public class PollResultModel
    {
        public int Id { get; set; }

        public int EventId { get; set; }

        public string EventTitle { get; set; }

        public string PollQuestion { get; set; }

        public DateTime CreatedOn { get; set; }

        public List<PollAnswerInfoModel> PollAnswers { get; set; }
    }
}