using Newtonsoft.Json;

namespace xamarin_listings.Models
{
    public class Category
    {
        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}