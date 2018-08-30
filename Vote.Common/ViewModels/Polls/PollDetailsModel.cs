using System;
using System.Collections.Generic;
using System.Text;

namespace Vote.Common.ViewModels.Polls
{
    public class PollDetailsModel
    {
        public int Id { get; set; }

        public int EventId { get; set; }

        public string EventTitle { get; set; }

        public string PollQuestion { get; set; }

        public DateTime CreatedOn { get; set; }

        public List<string> PollAnswers { get; set; }

        public bool MutipleAnswers { get; set; }

        public bool IsClosed { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }
    }
}
