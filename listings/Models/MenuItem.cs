namespace listings.Models
{
    public enum MenuItemType {
        AnnouncementsList,
        AnnouncementDeposit,
        Messages,
        AnnouncementReceivedMessages,
        AnnouncementSentMessages
    }
    public class MenuItem
    {
        public MenuItemType Id { get; set; }
        public string Title { get; set; }
        public bool Enabled { get; set; }
    }
}