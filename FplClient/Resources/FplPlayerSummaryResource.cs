using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Api.Resources
{
    public class FplPlayerSummaryResource
    {
        [JsonProperty("history_past")]
        public ICollection<FplPlayerSeasonHistoryResource> SeasonHistory { get; set; }

        [JsonProperty("fixtures")]
        public ICollection<FplPlayerFixtureResource> Fixtures { get; set; }

        [JsonProperty("history")]
        public ICollection<FplPlayerMatchStatsResource> MatchStats { get; set; }
    }
}
