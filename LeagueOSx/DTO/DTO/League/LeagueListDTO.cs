using System;
using System.Collections.Generic;
namespace LeagueOSx.DTO {
    public class LeagueListDTO {
        public string leagueId { get; set; }
        public string tier { get; set; }
        public List<LeagueItemDTO> entries { get; set; }
        public string queue { get; set; }
        public string name { get; set; }
    }
}