using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Falea.Models
{
    public class MatchPlayer
    {
        public long MatchId { get; set; }
        public virtual Match Match { get; set; }

        public long PlayerId { get; set; }
        public virtual Player Player { get; set; }

        public int PositionPlayed { get; set; }
        public int PointsEarned { get; set; }
    }
}
