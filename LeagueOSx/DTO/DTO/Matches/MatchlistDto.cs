using System.Collections.Generic;
namespace LeagueOSx.DTO {
    public class MatchlistDto {
        public List<MatchReferenceDto> matches { get; set; }
        public int totalGames { get; set; }
        public int startIndex { get; set; }
        public int endIndex { get; set; }
    }
}
