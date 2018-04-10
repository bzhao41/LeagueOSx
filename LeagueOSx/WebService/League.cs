using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using LeagueOSx.DTO;

namespace LeagueOSx.WebService {
    public partial class APIHandler {
        string L_VERSION = "v3";

        //Get the challenger league for solo 5v5
        public async Task<LeagueListDTO> GetChallengerSoloAsync() {
            LeagueListDTO LeagueList = null;
            string request = "/lol/league/" + L_VERSION + "/challengerleagues/by-queue/RANKED_SOLO_5x5";
            string response = await GET(request);
            LeagueList = JsonConvert.DeserializeObject<LeagueListDTO>(response);
            return LeagueList;
        }

        //Get the challenger league for flex 5v5
        public async Task<LeagueListDTO> GetChallenger5sAsync() {
            LeagueListDTO LeagueList = null;
            string request = "/lol/league/" + L_VERSION + "/challengerleagues/by-queue/RANKED_FLEX_SR";
            string response = await GET(request);
            LeagueList = JsonConvert.DeserializeObject<LeagueListDTO>(response);
            return LeagueList;
        }

        //Get the challenger league for flex 3v3
        public async Task<LeagueListDTO> GetChallenger3sAsync() {
            LeagueListDTO LeagueList = null;
            string request = "/lol/league/" + L_VERSION + "/challengerleagues/by-queue/RANKED_FLEX_TT";
            string response = await GET(request);
            LeagueList = JsonConvert.DeserializeObject<LeagueListDTO>(response);
            return LeagueList;
        }

        //Get league with given ID, including inactive entries
        //CONSISTENTLY LOOKING UP LEAGUES THAT DON'T EXIST WILL RESULT IN A BLACKLIST.
        public async Task<LeagueListDTO> GetLeagueListAsync(string leagueID) {
            LeagueListDTO LeagueList = null;
            string request = "/lol/league/" + L_VERSION + "/leagues/" + leagueID;
            string response = await GET(request);
            LeagueList = JsonConvert.DeserializeObject<LeagueListDTO>(response);
            return LeagueList;
        }

        //Get the masters league for solo 5v5
        public async Task<LeagueListDTO> GetMasterSoloAsync() {
            LeagueListDTO LeagueList = null;
            string request = "/lol/league/" + L_VERSION + "/masterleagues/by-queue/RANKED_SOLO_5x5";
            string response = await GET(request);
            LeagueList = JsonConvert.DeserializeObject<LeagueListDTO>(response);
            return LeagueList;
        }

        //Get the masters league for flex 5v5
        public async Task<LeagueListDTO> GetMaster5sAsync() {
            LeagueListDTO LeagueList = null;
            string request = "/lol/league/" + L_VERSION + "/masterleagues/by-queue/RANKED_FLEX_SR";
            string response = await GET(request);
            LeagueList = JsonConvert.DeserializeObject<LeagueListDTO>(response);
            return LeagueList;
        }

        //Get the masters league for flex 3v3
        public async Task<LeagueListDTO> GetMaster3sAsync() {
            LeagueListDTO LeagueList = null;
            string request = "/lol/league/" + L_VERSION + "/masterleagues/by-queue/RANKED_FLEX_TT";
            string response = await GET(request);
            LeagueList = JsonConvert.DeserializeObject<LeagueListDTO>(response);
            return LeagueList;
        }

        //Get league positions in all queues for a given summoner ID
        public async Task<List<LeaguePositionDTO>> GetPositionListAsync(long summonerID) {
            List<LeaguePositionDTO> LeagueList = null;
            string request = "/lol/league/" + L_VERSION + "/positions/by-summoner/" + summonerID;
            string response = await GET(request);
            LeagueList = JsonConvert.DeserializeObject<List<LeaguePositionDTO>>(response);
            return LeagueList;
        }
    }
}
