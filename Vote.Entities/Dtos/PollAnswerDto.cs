namespace Vote.Entities.Dtos
{
    public class PollAnswerDto
    {
        public string Content { get; set; }

        public int Votes { get; set; }

        public int PollId { get; set; }
    }
}