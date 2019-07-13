using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Falea.Models
{
    public class Team
    {
        public long Id { get; set; }
        [Key]
        public long DotaId { get; set; }
        public string Name { get; set; }

        public virtual List<Player> Players { get; set; }
    }
}
