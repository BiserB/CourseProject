using System;
using System.Collections.Generic;

namespace Vote.Common.ViewModels.Events
{
    public class QuestionViewModel
    {
        public string AuthorName { get; set; }

        public string Content { get; set; }

        public DateTime PublishedOn { get; set; }

        public int Upvotes { get; set; }

        public int Doqwnvotes { get; set; }

        public List<ReplyViewModel> Replies { get; set; }
    }
}