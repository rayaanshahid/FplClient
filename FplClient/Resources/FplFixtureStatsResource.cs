using Newtonsoft.Json;

namespace FplClient.Api.Resources
{
    public class FplFixtureStatsResource
    {
        [JsonProperty("goals_scored")]
        public FplFixtureStatResource GoalsScored { get; set; }

        [JsonProperty("assists")]
        public FplFixtureStatResource Assists { get; set; }

        [JsonProperty("own_goals")]
        public FplFixtureStatResource OwnGoals { get; set; }

        [JsonProperty("penalties_saved")]
        public FplFixtureStatResource PenaltiesSaved { get; set; }

        [JsonProperty("penalties_missed")]
        public FplFixtureStatResource PenaltiesMissed { get; set; }

        [JsonProperty("yellow_cards")]
        public FplFixtureStatResource YellowCards { get; set; }

        [JsonProperty("red_cards")]
        public FplFixtureStatResource RedCards { get; set; }

        [JsonProperty("saves")]
        public FplFixtureStatResource Saves { get; set; }

        [JsonProperty("bonus")]
        public FplFixtureStatResource Bonus { get; set; }

        [JsonProperty("bps")]
        public FplFixtureStatResource Bps { get; set; }
    }
}
