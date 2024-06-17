using Newtonsoft.Json;


namespace BullsRideToTampa.Models
{
    public class Place
    {
        [JsonProperty("business_id")]
        public string BusinessId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("type_id")]
        public string TypeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("timings")]
        public Dictionary<string, string> Timings { get; set; }

        [JsonProperty("Price")]
        public string Price { get; set; }
    }
}
