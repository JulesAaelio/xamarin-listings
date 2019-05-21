using System.Collections.Generic;
using Newtonsoft.Json;

namespace xamarin_listings.Models
{
    public class Announcement_API: ListingApiResponse
    {
        [JsonProperty("announcements")]
        public List<Announcement> Announcements { get; set; }
    }
}