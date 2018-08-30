using System;

namespace Vote.Entities.Dtos
{
    public class PollDto
    {
        public PollDto()
        {
            this.MutipleAnswers = false;
            this.IsActive = false;
            this.IsClosed = false;
            this.IsDeleted = false;
        }

        public int EventId { get; set; }

        public int PollQuestionId { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool MutipleAnswers { get; set; }

        public bool IsClosed { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }
    }
}