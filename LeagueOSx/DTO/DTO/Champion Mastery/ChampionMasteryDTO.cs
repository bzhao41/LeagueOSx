using System;
namespace LeagueOSx.DTO {
    public class ChampionMasteryDTO {
        public bool chestGranted { get; set; }
        public int championLevel { get; set; }
        public int championPoints { get; set; }
        public long championId { get; set; }
        public long playerId { get; set; }
        public long championPointsUntilNextLevel { get; set; }
        public int tokensEarned { get; set; }
        public long championPointsSinceLastLevel { get; set; }
        public long lastPlayTime { get; set; }
    }
}
