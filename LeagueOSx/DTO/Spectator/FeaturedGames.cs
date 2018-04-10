using System.Collections.Generic;
namespace LeagueOS.DTO.Spectator {
    public class FeaturedGames {
        public long clientRefreshInterval { get; set; }
        public IList<FeaturedGameInfo> gameList { get; set; }
    }
}
