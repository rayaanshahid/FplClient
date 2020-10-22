using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Api.Resources
{
    public class FplLiveGameweekStatsResource
    {
        [JsonProperty("elements")]
        public IList<FplLivePlayerStatsResource> Elements { get; set; }
    }
}
