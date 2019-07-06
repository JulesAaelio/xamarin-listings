using Newtonsoft.Json;

namespace listings.Models
{
    public class MessageApi
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("announcement_id")]
        public string AnnouncementId { get; set; }
    }
}