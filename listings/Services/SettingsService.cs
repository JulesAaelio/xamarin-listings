using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace listings.Services
{
    public class SettingsService
    {
        private const string EMAIL = "email";
        private const string PASSWORD = "pwd";
        private const string TOKEN = "token"; 
        
        public static string Email
        {
            get
            {
                return Preferences.Get(EMAIL, "");
            }
            set
            {
                Preferences.Set(EMAIL, value);
            }
        }

        public static string Pwd
        {
            get
            {
                return Preferences.Get(PASSWORD, "");
            }
            set
            {
                Preferences.Set(PASSWORD, value);
            }
        }

        public static string TokenAPI
        {
            get
            {
                return Preferences.Get(TOKEN, "");
            }
            set
            {
                Preferences.Set(TOKEN, value);
            }
        }

        public static bool IsUserConnected
        {
            get
            {
                if (!String.IsNullOrWhiteSpace(Email) 
                    && !String.IsNullOrWhiteSpace(Pwd) 
                    && !String.IsNullOrWhiteSpace(TokenAPI))
                {
                    return true;
                }
                return false;
            }
        }

    }
}