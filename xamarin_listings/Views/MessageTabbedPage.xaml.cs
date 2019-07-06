using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin_listings.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MessageTabbedPage : TabbedPage
    {
        public MessageTabbedPage()
        {
            InitializeComponent();
            Children.Add(new NavigationPage(new MessagePage(false)){Title = "Envoyés"});
            Children.Add(new NavigationPage(new MessagePage(true)){Title = "Recus"});
        }
    }
}
