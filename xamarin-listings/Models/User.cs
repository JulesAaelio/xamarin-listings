using Newtonsoft.Json;

namespace xamarin-listings.Models
{
    public class User
    {
        [JsonProperty("firstname")]
        public string Firstname { get; set; }
        
        [JsonProperty("lastname")]
        public string Lastname { get; set; }
       
    }
}