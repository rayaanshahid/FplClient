﻿using Newtonsoft.Json;

namespace FplClient.Core.Models
{
    public class FplLiveFixtureStat
    {
        [JsonProperty("identifier")]
        public FplFixtureStatType Identifier { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }
}
