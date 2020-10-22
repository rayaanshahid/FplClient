using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Core.Models
{
    public class FplLiveFixtureStats
    {
        [JsonProperty("fixture")]
        public long FixtureId { get; set; }

        [JsonProperty("stats")]
        public IList<FplLiveFixtureStat> Stats { get; set; }
    }
}
