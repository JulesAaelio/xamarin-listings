using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace listings.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnnouncementDepositPage : ContentPage
    {
        public AnnouncementDepositPage()
        {
            InitializeComponent();
            BindingContext = new AnnouncementDepositPageViewModel();
        }
    }
}
