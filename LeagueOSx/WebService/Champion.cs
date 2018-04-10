using System.Threading.Tasks;
using Newtonsoft.Json;
using LeagueOSx.DTO;

namespace LeagueOSx.WebService {
    public partial class APIHandler {
        string C_VERSION = "v3";

        //Retrieve all champions
        public async Task<ChampionListDto> GetChampionsAsync() {
            ChampionListDto champions = null;
            string request = "/lol/platform/" + C_VERSION + "/champions";
            string response = await GET(request);
            champions = JsonConvert.DeserializeObject<ChampionListDto>(response);
            return champions;
        }

        //Retrieve champion by ID
        public async Task<ChampionDto> GetChampionAsync(long championID) {
            ChampionDto champion = null;
            string request = "/lol/platform/" + C_VERSION + "/champions/" + championID;
            string response = await GET(request);
            champion = JsonConvert.DeserializeObject<ChampionDto>(response);
            return champion;
        }
    }
}
