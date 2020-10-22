using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Api.Resources
{
    public class FplLivePlayerStatsResource
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("stats")]
        public FplPickStatsResource Stats { get; set; }

        [JsonProperty("explain")]
        public IList<FplLiveFixtureStatsResource> PointsBreakdown { get; set; }
    }
}
