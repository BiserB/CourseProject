using System.Collections.Generic;

namespace Vote.Common.ViewModels.Polls
{
    public class PollPanelModel
    {
        public PollPanelModel()
        {
            this.Polls = new List<PollViewModel>();
        }

        public List<PollViewModel> Polls { get; set; }

        public int EventId { get; set; }

        public string EventCode { get; set; }

        public string EventTitle { get; set; }

        public bool IsPastEvent { get; set; }
    }
}