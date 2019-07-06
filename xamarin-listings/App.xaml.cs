using System;
using xamarin-listings.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace xamarin-listings
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Login();
//            MainPage = new xamarin-listings.Views.MasterDetailPage();
        }
        
        

        protected override void OnStart()
        {
            AppCenter.Start("android=f10a272c-0308-4fea-91ee-a529ab3f22cb;", typeof(Analytics), typeof(Crashes));
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}