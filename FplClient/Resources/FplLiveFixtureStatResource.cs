using Newtonsoft.Json;

namespace FplClient.Api.Resources
{
    public class FplLiveFixtureStatResource
    {
        [JsonProperty("identifier")]
        public FplFixtureStatTypeResource Identifier { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }
}
