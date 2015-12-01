using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonthlyBudget.Common.Services;

namespace MonthlyBudget.Common.ViewModels
{
    public abstract class BaseViewModelCommon
    {
        protected BaseViewModelCommon(ILog log)
        {
            Log = log;
            Caller = "BaseViewModelCommon";}

        public ILog Log { get; set; }
        public string Caller { get; set; }
    }
}
