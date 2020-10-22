using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Api.Resources
{
    public class FplFixtureStatResource
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("a")]
        public ICollection<FplFixtureStatValueResource> AwayStats { get; set; }

        [JsonProperty("h")]
        public ICollection<FplFixtureStatValueResource> HomeStats { get; set; }
    }
}
