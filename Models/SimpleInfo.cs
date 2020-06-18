using Newtonsoft.Json;

namespace CosmosDbDemo.Models
{
    public class SimpleInfo
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}