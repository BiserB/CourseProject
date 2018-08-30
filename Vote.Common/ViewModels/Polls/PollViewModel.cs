using System;
using System.ComponentModel.DataAnnotations;

namespace Vote.Common.ViewModels.Polls
{
    public class PollViewModel
    {
        public int Id { get; set; }

        [Required]
        public string PollQuestion { get; set; }

        public int Votes { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsActive { get; set; }
    }
}