using System.Collections.Generic;
namespace LeagueOSx.DTO {
    public class FeaturedGames {
        public long clientRefreshInterval { get; set; }
        public List<FeaturedGameInfo> gameList { get; set; }
    }
}
