using System;
using System.Collections.Generic;
using xamarin-listings.Models;
using xamarin-listings.Services;

namespace xamarin-listings.Views
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