using System.Threading.Tasks;
using Newtonsoft.Json;
using LeagueOSx.DTO;

namespace LeagueOSx.WebService {
    public partial class APIHandler {
        string SM_VERSION = "v3";

        //Get a summoner by account ID
        public async Task<SummonerDTO> GetSummonerByAccountAsync(long accountID) {
            SummonerDTO summoner = null;
            string request = "/lol/summoner/" + SM_VERSION + "/summoners/by-account/" + accountID;
            string response = await GET(request);
            summoner = JsonConvert.DeserializeObject<SummonerDTO>(response);
            return summoner;
        }

        //Get a summoner by summoner name
        public async Task<SummonerDTO> GetSummonerByNameAsync(string summonerName) {
            SummonerDTO summoner = null;
            string request = "/lol/summoner/" + SM_VERSION + "/summoners/by-name/" + summonerName;
            string response = await GET(request);
            summoner = JsonConvert.DeserializeObject<SummonerDTO>(response);
            return summoner;
        }

        //Get a summoner by summoner ID
        public async Task<SummonerDTO> GetSummonerByIDAsync(string summonerID) {
            SummonerDTO summoner = null;
            string request = "/lol/summoner/" + SM_VERSION + "/summoners/" + summonerID;
            string response = await GET(request);
            summoner = JsonConvert.DeserializeObject<SummonerDTO>(response);
            return summoner;
        }
    }
}
