using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Api.Resources
{
    public class FplEntryPicksResource
    {
        [JsonProperty("entry_history")]
        public FplEventEntryHistoryResource EventEntryHistory { get; set; }

        [JsonProperty("automatic_subs")]
        public ICollection<FplAutomaticSubResource> AutomaticSubs { get; set; }

        [JsonProperty("picks")]
        public ICollection<FplPickResource> Picks { get; set; }

        [JsonProperty("active_chip")]
        public string ActiveChip { get; set; }
    }
}
