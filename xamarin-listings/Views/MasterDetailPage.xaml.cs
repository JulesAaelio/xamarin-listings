using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xamarin_listings.Models;
using Xamarin.Forms;
using MenuItem = Xamarin.Forms.MenuItem;

namespace xamarin_listings.Views
{
    public partial class MasterDetailPage : Xamarin.Forms.MasterDetailPage
    {
        public MasterDetailPage()
        {
            InitializeComponent();
            BindingContext = new MasterDetailPageViewModel();

            MasterPage.ListViewMenu.ItemSelected += OnMenuItemSelected;
            //            Master = new MasterPage();
        }

        void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MenuItem;
            if (item != null)
            {
            }
        }
    }
}