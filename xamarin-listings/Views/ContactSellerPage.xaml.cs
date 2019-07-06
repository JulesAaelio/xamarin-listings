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
    public partial class ContactSellerPage : ContentPage
    {
        public ContactSellerPage(Announcement announcement)
        {
            InitializeComponent();
            BindingContext = new ContactSellerPageViewModel(announcement);
        }
    }
}
