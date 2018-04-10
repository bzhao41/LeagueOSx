using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using LeagueOSx.DTO;

namespace LeagueOSx.WebService {
    public partial class APIHandler {
        string CM_VERSION = "v3";
        //Get all champion mastery entries sorted by number of champion points descending
        public async Task<List<ChampionMasteryDTO>> GetChampionMasteriesAsync(long summonerID) {
            List<ChampionMasteryDTO> championMasteries = null;
            string request = "/lol/champion-mastery/" + CM_VERSION +"/champion-masteries/by-summoner/" + summonerID;
            string response = await GET(request);
            championMasteries = JsonConvert.DeserializeObject<List<ChampionMasteryDTO>>(response);
            return championMasteries;
        }

        //Get a champion mastery by player ID and champion ID
        public async Task<ChampionMasteryDTO> GetChampionMasteriesByChampionAsync(long summonerID, long championID) {
            ChampionMasteryDTO championMastery = null;
            string request = "/lol/champion-mastery/" + CM_VERSION + "/champion-masteries/by-summoner/" + summonerID + "/by-champion/" + championID;
            string response = await GET(request);
            championMastery = JsonConvert.DeserializeObject<ChampionMasteryDTO>(response);
            return championMastery;
        }

        //Get a player's total champion mastery score, which is the sum of individual champion mastery levels
        public async Task<int> GetChampionScoresAsync(long summonerID) {
            string request = "/lol/champion-mastery/" + CM_VERSION +"/scores/by-summoner/" + summonerID;
            string result = await GET(request);
            return Int32.Parse(result);
        }
    }
}
