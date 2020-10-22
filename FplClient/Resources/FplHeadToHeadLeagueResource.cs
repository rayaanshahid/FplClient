using Newtonsoft.Json;

namespace FplClient.Api.Resources
{
    public class FplHeadToHeadLeagueResource
    {
        [JsonProperty("new_entries")]
        public FplNewLeagueEntriesResource NewEntries { get; set; }

        [JsonProperty("league")]
        public FplHeadToHeadLeaguePropertiesResource Properties { get; set; }

        [JsonProperty("standings")]
        public FplHeadToHeadLeagueStandingsResource Standings { get; set; }

        [JsonProperty("matches_next")]
        public FplHeadToHeadLeagueMatchesResource Next { get; set; }

        [JsonProperty("matches_this")]
        public FplHeadToHeadLeagueMatchesResource Current { get; set; }
    }
}
