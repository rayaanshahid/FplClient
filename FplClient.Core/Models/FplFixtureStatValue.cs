using Newtonsoft.Json;

namespace FplClient.Core.Models
{
    public class FplFixtureStatValue
    {
        [JsonProperty("element")]
        public int Element { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }
}
