using System.ComponentModel.DataAnnotations;

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

        [Display(Name = "Display name")]
        [StringLength(32, ErrorMessage = "The {0} must be max {1} characters long.")]
        public string ReplyAuthor { get; set; }

        [Required]
        [StringLength(256, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        [DataType(DataType.MultilineText)]
        public string ReplyContent { get; set; }
    }
}