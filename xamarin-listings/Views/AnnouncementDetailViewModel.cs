using xamarin-listings.Models;

namespace xamarin-listings.Views
{
    public class AnnouncementDetailViewModel: BaseViewModel
    {
        private Announcement _announcement;

        public Announcement Announcement
        {
            get => _announcement;
            set
            {
                _announcement = value;
                OnPropertyChanged("Announcement");
            }

        }

        public AnnouncementDetailViewModel(Announcement announcement)
        {
            Announcement = announcement;
        }
    }
}