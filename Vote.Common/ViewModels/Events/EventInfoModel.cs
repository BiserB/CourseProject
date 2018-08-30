namespace Vote.Common.ViewModels.Events
{
    public class EventInfoModel
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Title { get; set; }

        public bool IsPastEvent { get; set; }
    }
}