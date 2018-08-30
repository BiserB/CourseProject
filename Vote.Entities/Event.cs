using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vote.Entities
{
    public class Event
    {
        public Event()
        {
            this.Questions = new List<Question>();
            this.Polls = new List<Poll>();
            this.IsClosed = false;
            this.AnonymousAllowed = true;
            this.IsDeleted = false;
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        public string Code { get; set; }

        [Required]
        [MaxLength(256)]
        public string Title { get; set; }

        [Required]
        public string CreatorId { get; set; }

        [Required]
        public User Creator { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsClosed { get; set; }

        public bool AnonymousAllowed { get; set; }

        public bool IsDeleted { get; set; }

        public List<Question> Questions { get; set; }

        public List<Poll> Polls { get; set; }
    }
}