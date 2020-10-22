using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Core.Models
{
    public class FplEntryLeagues
    {
        [JsonProperty("h2h")]
        public IList<FplEntryHeadToHeadLeague> HeadToHeadLeagues { get; set; }

        [JsonProperty("classic")]
        public IList<FplEntryClassicLeague> ClassicLeagues { get; set; } 
    }
}
