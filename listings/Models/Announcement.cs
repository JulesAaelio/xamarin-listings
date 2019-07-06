using Newtonsoft.Json;

namespace listings.Models
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
        public double CategoryId { get; set; }
        
        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("price")]
        public float Price { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }
        
        [JsonProperty("picture")]
        public string Picture { get; set; }
    }
}