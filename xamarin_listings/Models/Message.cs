using Newtonsoft.Json;

namespace xamarin_listings.Models
{
    public class Message
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("announcement")]
        public Announcement Announcement { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }
}