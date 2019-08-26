using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vote.Entities
{
    public class Question
    {
        public Question()
        {
            this.IsArchived = false;
            this.IsDeleted = false;
            this.Replies = new List<Reply>();
        }

        public int Id { get; set; }

        public string AuthorId { get; set; }

        public User Author { get; set; }

        [Required]
        public string AuthorName { get; set; }

        public int EventId { get; set; }

        [Required]
        public Event Event { get; set; }

        [MaxLength(256)]
        public string Content { get; set; }

        public DateTime PublishedOn { get; set; }

        public int Upvotes { get; set; }

        public int Downvotes { get; set; }

        public bool IsArchived { get; set; }

        public bool IsReviewed { get; set; }

        public bool IsDeleted { get; set; }

        public List<Reply> Replies { get; set; }
    }
}