using System;
namespace LeagueOS.DTO.Spectator {
    public class BannedChampion {
        public int pickTurn { get; set; }
        public long championId { get; set; }
        public long teamId { get; set; }
    }
}
