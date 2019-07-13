using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Falea.Models
{
    public class DraftPick
    {
        public long Id { get; set; }

        public uint Cost { get; set; }

        public long PlayerId { get; set; }
        public virtual Player Player { get; set; }

        public long DraftId { get; set; }
        public virtual Draft Draft { get; set; }
    }
}
