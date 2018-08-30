using System.Collections.Generic;

namespace Vote.Common.ViewModels.Events
{
    public class AllEventsModel
    {
        public ICollection<EventViewModel> ActiveEvents { get; set; }

        public ICollection<EventViewModel> PastEvents { get; set; }
    }
}