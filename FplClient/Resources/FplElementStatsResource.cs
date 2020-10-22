using Newtonsoft.Json;

namespace FplClient.Api.Resources
{
    public class FplElementStatsResource
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
