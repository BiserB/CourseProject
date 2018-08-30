using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vote.Common.BindingModels
{
    public class PollBindingModel
    {
        public PollBindingModel()
        {
            this.Answers = new List<string>();
        }

        public int Id { get; set; }

        public int EventId { get; set; }

        [Required]
        public string EventCode { get; set; }

        [Required]
        public string EventTitle { get; set; }

        [Required]
        public string PollQuestion { get; set; }

        //public string Answer1 { get; set; }
        //public string Answer2 { get; set; }
        //public string Answer3 { get; set; }
        //public string Answer4 { get; set; }
        //public string Answer5 { get; set; }
        //public string Answer6 { get; set; }

        public List<string> Answers { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool MutipleAnswers { get; set; }

        public bool IsClosed { get; set; }

        public bool IsArchived { get; set; }

        public bool IsDeleted { get; set; }
    }
}