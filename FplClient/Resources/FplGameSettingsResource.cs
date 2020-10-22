using Newtonsoft.Json;

namespace FplClient.Api.Resources
{
    public class FplGameSettingsResource
    {
        [JsonProperty("game")]
        public FplGameResource Game { get; set; }
    }
}
