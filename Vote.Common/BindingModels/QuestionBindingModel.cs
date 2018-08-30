using System;
using System.ComponentModel.DataAnnotations;

namespace Vote.Common.BindingModels
{
    public class QuestionBindingModel
    {
        public QuestionBindingModel()
        {
            this.ParticipantName = VoteConstants.Anonymous;
        }

        public DateTime PublishedOn { get; set; }

        [Display(Name = "Display name")]
        [StringLength(32, ErrorMessage = "The {0} must be max {1} characters long.")]
        public string ParticipantName { get; set; }

        [Required]
        [StringLength(256, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
    }
}