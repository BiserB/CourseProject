using System.Collections.Generic;

namespace Vote.Common.ViewModels.Events
{
    public class QuestionFullModel
    {
        public QuestionFullModel()
        {
            this.Replies = new List<ReplyViewModel>();
        }

        public int Id { get; set; }

        public string AuthorName { get; set; }

        public string Content { get; set; }

        public string PublishedOn { get; set; }

        public int EventId { get; set; }

        public string EventCode { get; set; }

        public bool IsArchived { get; set; }

        public int Upvotes { get; set; }

        public int Doqwnvotes { get; set; }

        public List<ReplyViewModel> Replies { get; set; }
    }
}