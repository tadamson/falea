using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Falea.Models
{
    public class Tournament
    {
        public long Id { get; set; }

        [Key]
        public long DotaId { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual List<Team> TeamsAttending { get; set; }
        public virtual List<Match> Matches { get; set; }
        
        public ICollection<LeagueTournament> LeagueTournaments { get; set; }

        // multiplier to weigh certain tourneys (DPC/TI/etc) over others (JDL/Dotapit/etc)
        public float Weight { get; set; }

    }
}
