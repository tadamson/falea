using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Falea.Models
{
    public class Player
    {
        public long Id { get; set; }
        [Key]
        public long SteamId { get; set; }
        [Required]
        public string Nick { get; set; }
        [Required]
        public string Name { get; set; }
        public bool Active { get; set; }
        public int Position { get; set; }
        public int DraftCost { get; set; }

        public long TeamId { get; set; }
        public virtual Team Team { get; set; }

        public virtual List<PlayerStats> Stats { get; set; }
    }
}
