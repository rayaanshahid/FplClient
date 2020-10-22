using Newtonsoft.Json;

namespace FplClient.Core.Models
{
    public class FplClassicLeague
    {
        [JsonProperty("new_entries")]
        public FplNewLeagueEntries NewEntries { get; set; }

        [JsonProperty("league")]
        public FplClassicLeagueProperties Properties { get; set; }

        [JsonProperty("standings")]
        public FplClassicLeagueStandings Standings { get; set; }
    }
}
