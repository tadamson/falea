using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Falea.Models
{
    public class League
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }

        // our concept of leagues can encompass multiple tourneys, e.g. multiple inhouse seasons or all DPC events over a year
        // (expected this will be 1:1 for large events, but many:many for flexibility & smaller tourneys)
        public ICollection<LeagueTournament> LeagueTournaments { get; set; }
        
    }
}
