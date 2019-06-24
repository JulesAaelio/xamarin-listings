using System;
using System.Net.Http;
using Refit;

namespace xamarin_listings.Services
{
    public class ListingAPIService
    {
//        private static string _hostUrl = "http://listings.adriencabaud.fr/api/v1";
        private static string _hostUrl = "http://10.0.2.2:3000/api/v1";
        private static IListingAPI _listingApi;

        public static IListingAPI Instance
        {
            get
            {
                if (_listingApi == null)
                {
                    _listingApi = RestService.For<IListingAPI>(new HttpClient(new AuthenticatedHttpClientHandler()){BaseAddress = new Uri(_hostUrl)});
                }
                return _listingApi;
            }
        }
        private ListingAPIService()
        {
        }
    }
}