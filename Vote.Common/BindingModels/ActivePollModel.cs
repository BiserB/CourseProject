using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Vote.Common.BindingModels
{
    public class ActivePollModel
    {
        public int PollId { get; set; }

        [Required]
        public string EventCode { get; set; }

        [Required]
        public string PollQuestion { get; set; }

        public List<SelectListItem> PollAnswers { get; set; }
    }
}
