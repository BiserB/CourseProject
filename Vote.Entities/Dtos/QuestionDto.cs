using System;

namespace Vote.Entities.Dtos
{
    public class QuestionDto
    {
        public QuestionDto()
        {
            this.IsArchived = false;
            this.IsDeleted = false;
        }

        public string AuthorId { get; set; }

        public string AuthorName { get; set; }

        public int EventId { get; set; }

        public string Content { get; set; }

        public DateTime PublishedOn { get; set; }

        public bool IsArchived { get; set; }

        public bool IsDeleted { get; set; }
    }
}