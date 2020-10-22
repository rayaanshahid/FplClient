using Newtonsoft.Json;

namespace FplClient.Api.Resources
{
    public class FplClassicLeagueResource
    {
        [JsonProperty("new_entries")]
        public FplNewLeagueEntriesResource NewEntries { get; set; }

        [JsonProperty("league")]
        public FplClassicLeaguePropertiesResource Properties { get; set; }

        [JsonProperty("standings")]
        public FplClassicLeagueStandingsResource Standings { get; set; }
    }
}
