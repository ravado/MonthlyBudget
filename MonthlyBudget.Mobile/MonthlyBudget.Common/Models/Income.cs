using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyBudget.Common.Models
{
    public sealed class Income
    {
        public string Name { get; set; }
        public Money Money { get; set; }
        public bool Active { get; set; }
    }
}
