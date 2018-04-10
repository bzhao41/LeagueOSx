using System;
using System.Collections.Generic;
namespace LeagueOS.DTO {
    public class LeagueListDTO {
        public string leagueId { get; set; }
        public string tier { get; set; }
        public IList<LeagueItemDTO> entries { get; set; }
        public string queue { get; set; }
        public string name { get; set; }
    }
}