using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using LeagueOSx.DTO;

namespace LeagueOSx.WebService {
    public partial class APIHandler {
        string SP_VERSION = "v3";

        //Get current game information for the given summoner ID
        public async Task<CurrentGameInfo> GetCurrentGameAsync(long summonerID) {
            CurrentGameInfo current = null;
            string request = "/lol/spectator/" + SP_VERSION + "/active-games/by-summoner/" + summonerID;
            string response = await GET(request);
            current = JsonConvert.DeserializeObject<CurrentGameInfo>(response);
            return current;
        }

        //Get list of featured games
        public async Task<FeaturedGames> GetMatchTimelineAsync() {
            FeaturedGames featured = null;
            string request = "/lol/spectator/" + SP_VERSION + "/featured-games";
            string response = await GET(request);
            featured = JsonConvert.DeserializeObject<FeaturedGames>(response);
            return featured;
        }
    }
}
