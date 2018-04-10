using System.Collections.Generic;
namespace LeagueOS.DTO.Matches {
    public class MatchlistDto {
        public IList<MatchReferenceDto> matches { get; set; }
        public int totalGames { get; set; }
        public int startIndex { get; set; }
        public int endIndex { get; set; }
    }
}
