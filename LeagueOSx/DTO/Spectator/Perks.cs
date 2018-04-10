using System.Collections.Generic;
namespace LeagueOS.DTO.Spectator {
    public class Perks {
        public long perkStyle { get; set; }
        public IList<long> perkIds { get; set; }
        public long perkSubStyle { get; set; }
    }
}