﻿using System;
using System.Collections.Generic;
namespace LeagueOS.DTO.Matches {
    public class TeamStatsDto {
        public bool firstDragon { get; set; }
        public bool firstInhibitor { get; set; }
        public IList<TeamBansDto> bans { get; set; }
        public int baronKills { get; set; }
        public bool firstRiftHerald { get; set; }
        public bool firstBaron { get; set; }
        public int riftHeraldKills { get; set; }
        public bool firstBlood { get; set; }
        public int teamId { get; set; }
        public bool firstTower { get; set; }
        public int vilemawKills { get; set; }
        public int inhibitorKills { get; set; }
        public int towerKills { get; set; }
        public int dominionVictoryScore { get; set; }
        public string win { get; set; }
        public int dragonKills { get; set; }
    }
}
