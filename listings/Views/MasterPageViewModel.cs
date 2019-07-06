using System.Collections.Generic;
using listings.Models;
using listings.Services;
using MenuItem = listings.Models.MenuItem;

namespace listings.Views
{
    public class MasterPageViewModel: BaseViewModel
    {

        private string _username;
        public string Username
        {
            get { return this._username; }
            set
            {
                this._username = value;
                OnPropertyChanged("Username");
            } }
        public List<MenuItem> MenuItems { get; }

        public MasterPageViewModel()
        {
            this.MenuItems = new List<MenuItem>
            {
                new MenuItem {Id = MenuItemType.AnnouncementsList, Title= "Toutes les annonces", Enabled = true},
                new MenuItem {Id = MenuItemType.AnnouncementDeposit, Title= "Créer une annonce", Enabled = true},
                new MenuItem {Id = MenuItemType.Messages, Title= "Messages", Enabled = true}
            };
            LoadUser();
        }

        async void LoadUser()
        {
            User user = await ListingAPIService.Instance.GetUser();
            Username = user.Firstname + ' ' + user.Lastname;
        }
        
        
    }
}