using System;
using System.Net;
using System.Windows.Input;
using listings.Models;
using listings.Services;
using Xamarin.Forms;

namespace listings.Views
{
    public class LoginPageViewModel : BaseViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        
        public string ErrorMessage { get; set; }
        
        public ICommand LoginCommand { get; set; }
        public LoginPageViewModel()
        {
            this.Email = SettingsService.Email;
            this.Password = SettingsService.Pwd;
            this.LoginCommand = new Command(
                execute: () =>
                {
                    Login();
                });   
        }

        private async void Login()
        {
            Credentials credentials = new Credentials();
            credentials.Password = this.Password;
            credentials.Email = this.Email;

            try
            {
                Token_API response = await ListingAPIService.Instance.Login(credentials);
                SettingsService.TokenAPI = response.Token;
                SettingsService.Pwd = this.Password;
                SettingsService.Email = this.Email;
                Application.Current.MainPage = new MasterDetailPage();
            }
            catch (Refit.ApiException e)
            {
                if (e.StatusCode == HttpStatusCode.Unauthorized)
                {
                    ErrorMessage = "Bad Credentials";
                }
                else
                {
                    ErrorMessage = "Authentication is Broken";
                }
                OnPropertyChanged("ErrorMessage");
            }
            
        }
    }
}