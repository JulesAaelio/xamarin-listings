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
    public partial class MessagePage : ContentPage
    {
        public bool ReceivedMessageMode { get; set; }
        public MessagePage(bool receivedMessagesMode) 
        {
            InitializeComponent();
            this.ReceivedMessageMode = receivedMessagesMode;
            BindingContext = new MessagePageViewModel(this.ReceivedMessageMode);
        }
    }
}
