﻿using System.Collections.Generic;
namespace LeagueOSx.DTO {
    public class CurrentGameParticipant {
        public long profileIconId { get; set; }
        public long championId { get; set; }
        public string summonerName { get; set; }
        public List<GameCustomizationObject> gameCustomizationObjects { get; set; }
        public bool bot { get; set; }
        public Perks perks { get; set; }
        public long spell2Id { get; set; }
        public long teamId { get; set; }
        public long spell1Id { get; set; }
        public long summonerId { get; set; }
    }
}
