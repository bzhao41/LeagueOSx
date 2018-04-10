using System;
namespace LeagueOSx.DTO {
    public class Participant {
        public long profileIconId { get; set; }
        public long championId { get; set; }
        public string summonerName { get; set; }
        public bool bot { get; set; }
        public long spell2Id { get; set; }
        public long teamId { get; set; }
        public long spell1Id { get; set; }
    }
}
