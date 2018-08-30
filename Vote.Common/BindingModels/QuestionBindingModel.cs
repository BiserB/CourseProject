using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Vote.Common.BindingModels
{
    public class QuestionBindingModel
    {        
        public bool IsAnonimous { get; set; }

        public DateTime PublishedOn { get; set; }

        [Required]
        [Display(Name = "Display name")]
        [StringLength(32, ErrorMessage = "'{0}' must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string ParticipantName { get; set; }

        [Required]
        [StringLength(256, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
    }
}
