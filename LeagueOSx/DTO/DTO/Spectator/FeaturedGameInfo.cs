using System.Collections.Generic;
namespace LeagueOSx.DTO {
    public class FeaturedGameInfo {
        public long gameId { get; set; }
        public long gameStartTime { get; set; }
        public string platformId { get; set; }
        public string gameMode { get; set; }
        public long mapId { get; set; }
        public string gameType { get; set; }
        public List<BannedChampion> bannedChampions { get; set; }
        public Observer observers { get; set; }
        public List<Participant> participants { get; set; }
        public long gameLength { get; set; }
        public long gameQueueConfigId { get; set; }
    }
}
