namespace LibrarySystem.Api.ViewModels
{
    public class AnswersViewModel
    {
        public Item[] Items { get; set; }
        public bool HasMore { get; set; }
        public int BackOff { get; set; }
        public int QuotaMax { get; set; }
        public int QuotaRemaining { get; set; }
    }
}