using System;
namespace LeagueOSx.DTO {
    public class LeaguePositionDTO {
        public string rank { get; set; }
        public string queueType { get; set; }
        public bool hotStreak { get; set; }
        public MiniSeriesDTO miniSeries { get; set; }
        public int wins { get; set; }
        public bool veteran { get; set; }
        public int losses { get; set; }
        public bool freshBlood { get; set; }
        public string leagueId { get; set; }
        public string playerOrTeamName { get; set; }
        public bool inactive { get; set; }
        public string playerOrTeamId { get; set; }
        public string leagueName { get; set; }
        public string tier { get; set; }
        public int leaguePoints { get; set; }
        public string monsterSubType { get; set; }
        public string laneType { get; set; }
        public int itemId { get; set; }
        public int participantId { get; set; }
        public string buildingType { get; set; }
        public int creatorId { get; set; }
        public MatchPositionDto position { get; set; }
        public int beforeId { get; set; }
    }
}
