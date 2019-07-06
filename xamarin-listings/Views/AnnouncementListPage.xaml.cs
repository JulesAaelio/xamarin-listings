using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xamarin-listings.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin-listings.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnnouncementListPage : ContentPage
    {
        public AnnouncementListPage()
        {
            InitializeComponent();
            BindingContext = new AnnouncementListPageViewModel();
        }

        private void ListViewMenu_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Announcement;
            if (item != null)
            {
                Navigation.PushAsync(new AnnouncementDetail(item));
            }
        }
    }
}
