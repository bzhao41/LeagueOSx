using System;
namespace LeagueOS.DTO.Summoner {
    public class SummonerDTO {
        public int profileIconId { get; set; }
        public string name { get; set; }
        public long summonerLevel { get; set; }
        public long revisionDate { get; set; }
        public long id { get; set; }
        public long accountId { get; set; }
    }
}
