using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyBudget.Common.Models
{
    public sealed class Period
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
