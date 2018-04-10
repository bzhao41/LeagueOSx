using System.Collections.Generic;
namespace LeagueOS.DTO.Matches {
    public class MatchTimelineDto {
        public IList<MatchFrameDto> frames { get; set; }
        public long frameInterval { get; set; }
    }
}