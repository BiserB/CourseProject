using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Vote.Common.ViewModels.Events;

namespace Vote.Common.BindingModels
{
    public class JoinEventViewModel
    {
        public JoinEventViewModel()
        {
            
        }

        public int EventId { get; set; }        

        public string EventCode { get; set; }

        public string EventTitle { get; set; }

        public ICollection<QuestionFullModel> Questions { get; set; }

        public QuestionBindingModel Question { get; set; }

        public ReplyBindingModel Reply { get; set; }
    }
}
