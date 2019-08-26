using System;

namespace Vote.Common.ViewModels.Events
{
    public class EventViewModel
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Title { get; set; }

        public string CreatorId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsModerated { get; set; }

        public bool IsClosed { get; set; }
    }
}