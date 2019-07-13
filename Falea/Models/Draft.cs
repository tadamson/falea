using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace Falea.Models
{
    public class Draft
    {
        public long Id { get; set; }

        public int WalletAvailable { get; set; }
        public virtual League League { get; set; }

        [EnsureElementRange(3, 5, ErrorMessage = "Must have between 3 and 5 draft picks.")]
        public virtual List<DraftPick> Picks { get; set; }

        public bool IsValid()
        {
            uint total = CurrentPickCost();
            return (total > 0 && total <= this.WalletAvailable);
        }

        private uint CurrentPickCost()
        {
            uint total = 0;
            foreach (DraftPick pick in this.Picks)
            {
                total += pick.Cost;
            }
            return total;
        }
    }
}

// validator for draft pick quantity, should move this elsewhere if other custom validators pop up
// (or just use fluentvalidation package)
public class EnsureElementRangeAttribute : ValidationAttribute
{
    private readonly int minElements;
    private readonly int maxElements;

    public EnsureElementRangeAttribute(int min, int max)
    {
        minElements = min;
        maxElements = max;
    }

    public override bool IsValid(object value)
    {
        IList list = value as IList;
        if (list != null)
        {
            return (list.Count >= minElements && list.Count <= maxElements);
        }
        return false;
    }
}
