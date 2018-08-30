using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Vote.Common.BindingModels
{
    public class ReplyBindingModel
    {
        public ReplyBindingModel()
        {
            this.ReplyAuthor = VoteConstants.Anonymous;
        }

        public int EventId { get; set; }

        public string EventCode { get; set; }

        public int QuestionId { get; set; }

        [Required]
        [Display(Name = "Display name")]
        [StringLength(32, ErrorMessage = "{0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string ReplyAuthor { get; set; }

        [Required]
        [StringLength(256, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        [DataType(DataType.MultilineText)]
        public string ReplyContent { get; set; }
    }
}
