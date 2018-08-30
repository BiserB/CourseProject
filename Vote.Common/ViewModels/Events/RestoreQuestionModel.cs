using System;
using System.Collections.Generic;
using System.Text;

namespace Vote.Common.ViewModels.Events
{
    public class RestoreQuestionModel
    {
        public int Id { get; set; }

        public string AuthorName { get; set; }

        public string PublishedOn { get; set; }

        public string Content { get; set; }

        public ICollection<ReplyViewModel> Replies { get; set; }
    }
}
