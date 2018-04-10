using System;
using System.Collections.Generic;
namespace LeagueOS.DTO.Matches {
    public class ParticipantTimelineDto {
        public string lane { get; set; }
        public int participantId { get; set; }
        public IDictionary<string, double> csDiffPerMinDeltas { get; set; }
        public IDictionary<string, double> goldPerMinDeltas { get; set; }
        public IDictionary<string, double> xpDiffPerMinDeltas { get; set; }
        public IDictionary<string, double> creepsPerMinDeltas { get; set; }
        public IDictionary<string, double> xpPerMinDeltas { get; set; }
        public string role { get; set; }
        public IDictionary<string, double> damageTakenDiffPerMinDeltas { get; set; }
        public IDictionary<string, double> damageTakenPerMinDeltas { get; set; }
    }
}