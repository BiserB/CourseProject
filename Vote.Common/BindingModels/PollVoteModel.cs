using System.ComponentModel.DataAnnotations;

namespace Vote.Common.BindingModels
{
    public class PollVoteModel
    {
        public int PollId { get; set; }

        [Required]
        public string EventCode { get; set; }

        [Required]
        public string Option { get; set; }
    }
}