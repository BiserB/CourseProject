using System;
using System.Collections.Generic;

namespace Vote.Common.ViewModels.Events
{
    public class EventFullModel
    {
        public EventFullModel()
        {
            this.ActiveQuestions = new List<QuestionFullModel>();
            this.ArchivedQuestions = new List<QuestionFullModel>();
        }

        public int Id { get; set; }

        public string EventCode { get; set; }

        public string Title { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsClosed { get; set; }

        public bool AnonymousAllowed { get; set; }

        public List<QuestionFullModel> ActiveQuestions { get; set; }

        public List<QuestionFullModel> ArchivedQuestions { get; set; }
    }
}