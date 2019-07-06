using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xamarin_listings.Models;
using Xamarin.Forms;
using MenuItem = xamarin_listings.Models.MenuItem;

namespace xamarin_listings.Views
{
    public partial class MasterDetailPage : Xamarin.Forms.MasterDetailPage
    {
        public MasterDetailPage()
        {
            InitializeComponent();
            BindingContext = new MasterDetailPageViewModel();

            MasterPage.MenuItemSelected += OnMenuItemSelected;
            // Open announcement list
            Detail = new NavigationPage(new AnnouncementListPage());

        }

        void OnMenuItemSelected(object sender, EventArgs e)
        {
            var _event =  e as SelectedItemChangedEventArgs;
            Console.WriteLine(_event.SelectedItem);
            var item = _event.SelectedItem as MenuItem;
            if (item != null)
            {
                Page target = null;
                switch (item.Id)
                {
                    case MenuItemType.AnnouncementsList:
                        target = new NavigationPage(new AnnouncementListPage());
                        break;
                    case MenuItemType.AnnouncementDeposit:
                        target = new NavigationPage(new AnnouncementDepositPage());
                        break;
                    case MenuItemType.Messages:
                        target = new MessageTabbedPage();
                        break;
                }

                if (target != null)
                {
                    Detail = target;
                }
                IsPresented = false;
            }
        }
    }
}