using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using xamarin_listings.Models;

namespace xamarin_listings.Services
{
    public interface IListingAPI
    {
//        [Get("/5ce3a2593100008400742770")]
        [Get("/announcement")]
        Task<List<Announcement>> GetAnnouncements();
        
    }
}