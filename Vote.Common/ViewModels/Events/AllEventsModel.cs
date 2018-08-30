using System;
using System.Collections.Generic;
using System.Text;
using Vote.Common.BindingModels;

namespace Vote.Common.ViewModels.Events
{
    public class AllEventsModel
    {
        public ICollection<EventViewModel> ActiveEvents { get; set; }

        public ICollection<EventViewModel> PastEvents { get; set; }
    }
}
