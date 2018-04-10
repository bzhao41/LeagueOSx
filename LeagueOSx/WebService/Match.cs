using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using LeagueOSx.DTO;


namespace LeagueOSx.WebService {
    public partial class APIHandler {
        string M_VERSION = "v3";

        //Get match by match ID
        public async Task<MatchDto> GetMatchByIdAsync(long matchID) {
            MatchDto match = null;
            string request = "/lol/match/" + M_VERSION + "/matches/" + matchID;
            string response = await GET(request);
            match = JsonConvert.DeserializeObject<MatchDto>(response);
            return match;
        }

        //Get matchlist for games played on given account ID and platform ID and filtered using given filter parameters, if any
        //Construct requst uri 
        //Checks should be done on user end
        public async Task<MatchlistDto> GetMatchByAccountAsync(long accountID, 
                                                               long beginTime = -1, 
                                                               long endTime = -1, 
                                                               int beginIndex = -1,
                                                               int endIndex = -1,
                                                               List<int> champion = null, 
                                                               List<int> queue = null,
                                                               List<int> seasons = null) {
            MatchlistDto matches = null;
            string request = "/lol/match/" + M_VERSION + "/matchlists/by-account/" + accountID + "?";
            if (beginTime >= 0) {
                request += "&beginTime=" + beginTime;
            }
            if (endTime >= 0) {
                request += "&endTime=" + endTime;
            }
            if (beginIndex >= 0) {
                request += "&beginIndex=" + beginIndex;
            }
            if (endIndex >= 0) {
                request += "&endIndex=" + endIndex;
            }
            if (champion != null) {
                foreach (int element in champion) {
                    request += "&champion=" + element;
                }
            }
            if (queue != null) {
                foreach (int element in queue) {
                    request += "&queue=" + element;
                }
            }
            if (seasons != null) {
               foreach (int element in seasons) {
                    request += "&season=" + element;
                }
            }

            string response = await GET(request);
            matches = JsonConvert.DeserializeObject<MatchlistDto>(response);

            return matches;
        }

        //Get matchlist for last 20 matches played on given account ID and platform ID
        public async Task<MatchlistDto> GetRecentMatchesAsync(long accountID) {
            MatchlistDto matches = null;
            string request = "/lol/match/" + M_VERSION + "/matchlists/by-account/" + accountID + "/recent";
            string response = await GET(request);
            matches = JsonConvert.DeserializeObject<MatchlistDto>(response);
            return matches;
        }

        //Get match timeline by match ID
        public async Task<MatchTimelineDto> GetMatchTimelineAsync(long matchID) {
            MatchTimelineDto timeline = null;
            string request = "/lol/match/" + M_VERSION + "/timelines/by-match/" + matchID;
            string response = await GET(request);
            timeline = JsonConvert.DeserializeObject<MatchTimelineDto>(response);
            return timeline;
        }

        //Get match IDs by tournament code
        public async Task<List<long>> GetTournamentIDsAsync(string tournamentCode) {
            List<long> tournaments = null;
            string request = "/lol/match/" + M_VERSION + "/matches/by-tournament-code/" + tournamentCode + "/ids";
            string response = await GET(request);
            tournaments = JsonConvert.DeserializeObject<List<long>>(response);
            return tournaments;
        }

        //Get match by match ID and tournament code
        public async Task<MatchDto> GetTournamentMatchAsync(string tournamentCode, long matchID) {
            MatchDto tournament = null;
            string request = "/lol/match/" + M_VERSION + "/matches/" + matchID + "/by-tournament-code/" + tournamentCode;
            string response = await GET(request);
            tournament = JsonConvert.DeserializeObject<MatchDto>(response);
            return tournament;
        }
    }
}
