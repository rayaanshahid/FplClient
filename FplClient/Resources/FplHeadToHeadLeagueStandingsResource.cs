using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Api.Resources
{
    public class FplHeadToHeadLeagueStandingsResource
    {
        [JsonProperty("has_next")]
        public bool HasNext { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("results")]
        public ICollection<FplHeadToHeadLeagueEntryResource> Entries { get; set; }
    }
}
