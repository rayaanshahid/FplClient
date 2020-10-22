using Newtonsoft.Json;

namespace FplClient.Api.Resources
{
    public class FplFixtureStatValueResource
    {
        [JsonProperty("element")]
        public int Element { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }
}
