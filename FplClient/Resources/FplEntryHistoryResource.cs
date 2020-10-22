using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Api.Resources
{
    public class FplEntryHistoryResource
    {
        [JsonProperty("chips")]
        public ICollection<FplEntryHistoryChipResource> Chips { get; set; }

        [JsonProperty("past")]
        public ICollection<FplEntrySeasonHistoryResource> SeasonHistory { get; set; }

        [JsonProperty("current")]
        public ICollection<FplEventEntryHistoryResource> GameweekHistory { get; set; }
    }
}
