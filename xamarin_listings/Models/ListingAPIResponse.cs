using Newtonsoft.Json;

namespace xamarin_listings.Models
{
    public class ListingApiResponse
    {
        [JsonProperty("success")]
        public string Success { get; set; }
    }
    
}