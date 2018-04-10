using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Configuration;
using LeagueOSx.Constants;
namespace LeagueOSx.WebService {
    public partial class APIHandler {

        static HttpClient client;

        public APIHandler() {
            ExeConfigurationFileMap configMap = new ExeConfigurationFileMap();
            configMap.ExeConfigFilename = @"../";
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-Riot-Token", ConfigurationManager.AppSettings["API-KEY"]);
        }

        public async Task<string> GET(string request) {
            //string uri = Regions.NA1 + request + "?api_key=" + ConfigurationManager.AppSettings["API-KEY"];
            string uri = Regions.NA1 + request;
            string response = "";
            response = await client.GetStringAsync(uri);
            return response;
        }
    }
}
