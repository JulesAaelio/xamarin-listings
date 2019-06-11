using System;
using System.Collections.Generic;
using xamarin_listings.Models;
using xamarin_listings.Services;

namespace xamarin_listings.Views
{
    public class AnnouncementListPageViewModel: BaseViewModel
    {
        private List<Announcement> _announcements;

        public List<Announcement> Announcements
        {
            get { return _announcements; }
            set
            {
                this._announcements = value;
                OnPropertyChanged("Announcements");
            }
        }
        public AnnouncementListPageViewModel()
        {
            this.Load();
        }

        async void Load()
        {
            var response = await ListingAPIService.Instance.GetAnnouncements();
            Announcements = response;

        }
    }
}