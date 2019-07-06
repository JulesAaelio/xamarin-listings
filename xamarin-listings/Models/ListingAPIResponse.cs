using Newtonsoft.Json;

namespace xamarin-listings.Models
{
    public class ListingApiResponse
    {
        [JsonProperty("success")]
        public string Success { get; set; }
    }
    
}