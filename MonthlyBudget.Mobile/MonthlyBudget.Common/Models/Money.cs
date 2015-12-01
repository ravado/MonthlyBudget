using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyBudget.Common.Models
{
    public sealed class Money
    {
        public decimal Value { get; set; }
        public string Currency { get; set; }
    }
}
