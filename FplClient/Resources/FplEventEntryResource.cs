using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Api.Resources
{
    public class FplEventEntryResource
    {
        [JsonProperty("leagues")]
        public FplEntryLeaguesResource Leagues { get; set; }

        [JsonProperty("entry_history")]
        public FplEventEntryHistoryResource EventEntryHistory { get; set; }

        [JsonProperty("ce")]
        public string Ce { get; set; }

        [JsonProperty("automatic_subs")]
        public ICollection<FplAutomaticSubResource> AutomaticSubs { get; set; }

        [JsonProperty("fixtures")]
        public ICollection<FplFixtureResource> Fixture { get; set; }

        [JsonProperty("can_change_captain")]
        public bool CanChangeCaptain { get; set; }

        [JsonProperty("entry")]
        public FplEntryResource Entry { get; set; }

        [JsonProperty("picks")]
        public ICollection<FplPickResource> Picks { get; set; }

        [JsonProperty("own_entry")]
        public bool OwnEntry { get; set; }

        [JsonProperty("state")]
        public FplEventEntryStateResource State {get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("active_chip")]
        public string ActiveChip { get; set; }
    }
}
