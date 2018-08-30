using System;

namespace Vote.Entities.Dtos
{
    public class EventDto
    {
        public EventDto()
        {
            this.IsClosed = false;
            this.IsDeleted = false;
            this.AnonymousAllowed = true;
        }

        public string Code { get; set; }

        public string Title { get; set; }

        public string CreatorId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsClosed { get; set; }

        public bool AnonymousAllowed { get; set; }

        public bool IsDeleted { get; set; }
    }
}