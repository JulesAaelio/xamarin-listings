using System.Collections.Generic;
using System.Windows.Input;
using xamarin_listings.Models;
using xamarin_listings.Services;
using Xamarin.Forms;

namespace xamarin_listings.Views
{
    public class AnnouncementDepositPageViewModel : BaseViewModel
    {
        public ICommand CreateAnnouncementCommand { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        
        public Category SelectedCategory { get; set; }
        
        private List<Category> _categories;

        public List<Category> Categories
        {
            get { return _categories; }
            set
            {
                this._categories = value;
                OnPropertyChanged("Categories");
            }
        }
        
        public AnnouncementDepositPageViewModel()
        {
            this.CreateAnnouncementCommand = new Command(
                execute: () =>
                {
                    CreateAnnouncement();
                });

            Load();
        }

        private async void CreateAnnouncement()
        {
            Announcement announcement = new Announcement()
            {
                Title = this.Title, 
                Description = this.Description,
                Price = this.Price,
                CategoryId = this.SelectedCategory.Id
            };

            Announcement response = await ListingAPIService.Instance.PostAnnouncement(announcement);
            Application.Current.MainPage = new MasterDetailPage();
        }
        
        async void Load()
        {
            var response = await ListingAPIService.Instance.GetCategories();
            Categories = response;
        }
    }
}
