using System.Collections.Generic;
using xamarin_listings.Models;
using MenuItem = xamarin_listings.Models.MenuItem;

namespace xamarin_listings.Views
{
    public class MasterPageViewModel
    {

        public List<MenuItem> MenuItems { get; }

        public MasterPageViewModel()
        {
            this.MenuItems = new List<MenuItem>
            {
                new MenuItem {Id = MenuItemType.AnnouncementsList, Title= "Toutes les annonces", Enabled = true},
                new MenuItem {Id = MenuItemType.AnnouncementDeposit, Title= "Créer une annonce", Enabled = true}
            };
           
        }
        
        
    }
}