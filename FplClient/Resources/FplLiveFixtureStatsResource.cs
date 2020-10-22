using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Api.Resources
{
    public class FplLiveFixtureStatsResource
    {
        [JsonProperty("fixture")]
        public long FixtureId { get; set; }

        [JsonProperty("stats")]
        public IList<FplLiveFixtureStatResource> Stats { get; set; }
    }
}
