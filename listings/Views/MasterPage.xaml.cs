using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace listings.Views
{
    public partial class MasterPage : ContentPage
    {

        public event EventHandler MenuItemSelected;
        public MasterPage()
        {
            InitializeComponent();
            BindingContext = new MasterPageViewModel();
        }
        
        protected virtual void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Console.WriteLine("selected");
            var handler = MenuItemSelected;
            handler?.Invoke(this, e);
            ListViewMenu.SelectedItem = null;
        }
    }
}