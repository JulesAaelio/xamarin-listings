using System.Windows.Input;
using xamarin_listings.Models;
using xamarin_listings.Services;
using Xamarin.Forms;

namespace xamarin_listings.Views
{
    public class ContactSellerPageViewModel: BaseViewModel
    {
        private Announcement _announcement;
        public ICommand SendMessageCommand { get; set; }

        public string Content { get; set; }
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
            SendMessageCommand= new Command(() => { SendMessage(); });
        }

        async void SendMessage()
        {
            MessageApi message = new MessageApi();
            message.AnnouncementId = this.Announcement.Id;
            message.Content = this.Content;
            await ListingAPIService.Instance.PostMessage(message);
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}