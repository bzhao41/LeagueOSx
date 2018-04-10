using System.Collections.Generic;
namespace LeagueOSx.DTO {
    public class MatchFrameDto {
        public long timestamp { get; set; }
        public IDictionary<int, MatchParticipantFrameDto> participantFrames { get; set; }
        public IList<MatchEventDto> events { get; set; }
    }
}