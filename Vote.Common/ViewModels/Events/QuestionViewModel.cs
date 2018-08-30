using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
