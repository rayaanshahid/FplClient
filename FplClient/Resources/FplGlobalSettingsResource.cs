using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Api.Resources
{
    public class FplGlobalSettingsResource
    {
        [JsonProperty("teams")]
        public ICollection<FplTeamResource> Teams { get; set; }

        [JsonProperty("elements")]
        public ICollection<FplPlayerResource> Players { get; set; }

        [JsonProperty("events")]
        public ICollection<FplGameweekResource> Events { get; set; }

        [JsonProperty("element_types")]
        public ICollection<FplPlayerTypeResource> PlayerTypes { get; set; }

        [JsonProperty("game_settings")]
        public FplGameSettingsResource GameSettings { get; set; }

        [JsonProperty("phases")]
        public ICollection<FplPhaseResource> Phases { get; set; }

        [JsonProperty("element_stats")]
        public ICollection<FplElementStatsResource> StatsOptions { get; set; }

        [JsonProperty("total_players")]
        public long TotalPlayers { get; set; }
    }
}
