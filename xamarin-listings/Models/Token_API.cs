using Newtonsoft.Json;

namespace xamarin-listings.Models
{
    public class Token_API
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}