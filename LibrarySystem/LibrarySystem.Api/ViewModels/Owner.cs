namespace LibrarySystem.Api.ViewModels
{
    public class Owner
    {
        public int Reputation { get; set; }
        public int UserId { get; set; }
        public string UserType { get; set; }
        public string ProfileImage { get; set; }
        public string DisplayName { get; set; }
        public string Link { get; set; }
        public int AcceptRate { get; set; }
    }
}