using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Falea.Models
{
    /**
     * player stats: just a record of # matches played & fantasy points earned over a span
     * (from last record to DateRecorded). avoid more detail, this isn't dotabuff jr.
     */
    public class PlayerStats
    {
        public long Id { get; set; }

        public long PlayerId { get; set; }
        public virtual Player Player { get; set; }

        public DateTime DateRecorded { get; set; }
        public int MatchesPlayed { get; set; }
        public int PointsEarned { get; set; }
    }
}
