using Newtonsoft.Json;

namespace listings.Models
{
    public class ListingApiResponse
    {
        [JsonProperty("success")]
        public string Success { get; set; }
    }
    
}