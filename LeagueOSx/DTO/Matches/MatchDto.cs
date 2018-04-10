using System;
using System.Collections.Generic;
namespace LeagueOS.DTO.Matches {
    public class MatchDto {
        public int seasonId { get; set; }
        public int queueId { get; set; }
        public long gameId { get; set; }
        public IList<ParticipantIdentityDto> participantIdentities { get; set; }
        public string gameVersion { get; set; }
        public string platformId { get; set; }
        public string gameMode { get; set; }
        public int mapId { get; set; }
        public string gameType { get; set; }
        public IList<TeamStatsDto> teams { get; set; }
        public IList<ParticipantDto> participants { get; set; }
        public long gameDuration { get; set; }
        public long gameCreation { get; set; }
    }
}
