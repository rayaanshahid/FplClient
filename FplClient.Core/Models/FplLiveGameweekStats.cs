using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Core.Models
{
    public class FplLiveGameweekStats
    {
        [JsonProperty("elements")]
        public IList<FplLivePlayerStats> Elements { get; set; }
    }
}
