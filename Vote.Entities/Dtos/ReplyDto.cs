using System;

namespace Vote.Entities.Dtos
{
    public class ReplyDto
    {
        public int QuestionId { get; set; }

        public string AuthorName { get; set; }

        public string Content { get; set; }

        public DateTime PublishedOn { get; set; }
    }
}