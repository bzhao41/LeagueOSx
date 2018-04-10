using System.Collections.Generic;
namespace LeagueOS.DTO.Spectator {
    public class CurrentGameInfo {
        public long gameId { get; set; }
        public long gameStartTime { get; set; }
        public string platformId { get; set; }
        public string gameMode { get; set; }
        public long mapId { get; set; }
        public string gameType { get; set; }
        public IList<BannedChampion> bannedChampions { get; set; }
        public Observer observers { get; set; }
        public IList<CurrentGameParticipant> participants { get; set; }
        public long gameLength { get; set; }
        public long gameQueueConfigId { get; set; }
    }
}
