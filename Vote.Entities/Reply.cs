using System;
using System.ComponentModel.DataAnnotations;

namespace Vote.Entities
{
    public class Reply
    {
        public int Id { get; set; }

        public int QuestionId { get; set; }

        [Required]
        public Question Question { get; set; }

        [Required]
        public string AuthorName { get; set; }

        public string AuthorId { get; set; }

        public User Author { get; set; }

        [Required]
        [MaxLength(256)]
        public string Content { get; set; }

        public DateTime PublishedOn { get; set; }
    }
}