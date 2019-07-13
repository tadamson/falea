using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Falea.Models
{
    // intermediary relation between leagues & tourneys, because ef core
    public class LeagueTournament
    {
        public long LeagueId { get; set; }
        public League League { get; set; }

        public long TournamentId { get; set; }
        public Tournament Tournament { get; set; }
    }
}
