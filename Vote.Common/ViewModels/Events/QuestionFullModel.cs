using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vote.Common.ViewModels.Events
{
    public class QuestionFullModel
    {
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
