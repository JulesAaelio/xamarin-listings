using xamarin_listings.Models;

namespace xamarin_listings.Views
{
    public class ContactSellerPageViewModel: BaseViewModel
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

        public ContactSellerPageViewModel(Announcement announcement)
        {
            Announcement = announcement;
        }
    }
}