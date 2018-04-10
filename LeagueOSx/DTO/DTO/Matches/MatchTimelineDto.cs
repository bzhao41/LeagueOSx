using System.Collections.Generic;
namespace LeagueOSx.DTO {
    public class MatchTimelineDto {
        public List<MatchFrameDto> frames { get; set; }
        public long frameInterval { get; set; }
    }
}