using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xamarin_listings.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin_listings.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnnouncementDetail : ContentPage
    {
        public AnnouncementDetail(Announcement announcement)
        {
            InitializeComponent();
            BindingContext = new AnnouncementDetailViewModel(announcement);
        }
    }
}
