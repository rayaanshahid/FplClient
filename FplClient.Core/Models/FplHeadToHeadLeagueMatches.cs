﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Core.Models
{
    public class FplHeadToHeadLeagueMatches
    {
        [JsonProperty("has_next")]
        public bool HasNext { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("results")]
        public ICollection<FplHeadToHeadLeagueMatch> Matches { get; set; }
    }
}
