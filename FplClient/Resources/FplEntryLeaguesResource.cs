using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Api.Resources
{
    public class FplEntryLeaguesResource
    {
        [JsonProperty("h2h")]
        public IList<FplEntryHeadToHeadLeagueResource> HeadToHeadLeagues { get; set; }

        [JsonProperty("classic")]
        public IList<FplEntryClassicLeagueResource> ClassicLeagues { get; set; } 
    }
}
