namespace LibrarySystem.Api.ViewModels
{
    public class Item
    {
        public Owner Owner { get; set; }
        public bool IsAccepted { get; set; }
        public int Score { get; set; }
        public int LastActivityDate { get; set; }
        public int LastEditDate { get; set; }
        public int CreationDate { get; set; }
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public string ContentLicense { get; set; }
    }
}