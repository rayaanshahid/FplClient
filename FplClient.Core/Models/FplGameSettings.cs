using Newtonsoft.Json;

namespace FplClient.Core.Models
{
    public class FplGameSettings
    {
        [JsonProperty("game")]
        public FplGame Game { get; set; }
    }
}
