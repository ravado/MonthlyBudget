using System.Collections.ObjectModel;
using MonthlyBudget.Common.Models;
using MonthlyBudget.Common.Services;

namespace MonthlyBudget.Common.ViewModels
{
    public class MainViewModelCommon:BaseViewModelCommon
    {
        public virtual Period BudgetPeriod { get; set; }
        public virtual ObservableCollection<Expense> PlannedExpenses { get; set; }
        public virtual ObservableCollection<Income> Incomes { get; set; }
        public virtual Money TotalPlannedActiveExpenses { get; set; }
        public virtual Money TotalPlannedAllExpenses { get; set; }
        public virtual Money TotalIncomes { get; set; }

        public virtual string PlanedBudgetTite { get; set; }
        public virtual string IncomesTitle { get; set; }

        public MainViewModelCommon(ILog log) : base(log)
        {
            Caller = "MainViewModelCommon";
        }
    }
}