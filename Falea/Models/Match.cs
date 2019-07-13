using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Falea.Models
{
    public class Match
    {
        public long Id { get; set; }

        [Key]
        public long DotaId { get; set; }

        public virtual Team Radiant { get; set; }
        public virtual Team Dire { get; set; }
        public bool RadiantWin { get; set; }
        public int MatchLength { get; set; } // in seconds, don't need more

        public virtual List<MatchPlayer> Players { get; set; }

        public long LeagueId { get; set; }
        public virtual League League { get; set; }
    }
}
