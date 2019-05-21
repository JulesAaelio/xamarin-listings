using Newtonsoft.Json;

namespace xamarin_listings.Models
{
    public class Announcement
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}