using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MonthlyBudget.Common.Models;
using MonthlyBudget.Common.Services;
using MonthlyBudget.Common.ViewModels;
using MonthlyBudget.Phone.Annotations;

namespace MonthlyBudget.Phone.AL.ViewModels
{
    public sealed class MainViewModel:MainViewModelCommon, INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Fields

        private Period _budgetPeriod;
        private ObservableCollection<Expense> _plannedExpenses;
        private ObservableCollection<Income> _incomes;
        private Money _totalPlannedActiveExpenses;
        private Money _totalPlannedAllExpenses;
        private Money _totalIncomes;
        private string _planedBudgetTite;
        private string _incomesTitle;

        #endregion

        #region Properties

        public override Period BudgetPeriod { 
            get { return _budgetPeriod; }
            set
            {
                if (_budgetPeriod != value)
                {
                    _budgetPeriod = value;
                    OnPropertyChanged();
                }
            }
        }

        public override ObservableCollection<Expense> PlannedExpenses
        {
            get { return _plannedExpenses; }
            set
            {
                if (_plannedExpenses != value)
                {
                    _plannedExpenses = value;
                    OnPropertyChanged();
                }
            }
        }

        public override ObservableCollection<Income> Incomes
        {
            get { return _incomes; }
            set
            {
                if (_incomes != value)
                {
                    _incomes = value;
                    OnPropertyChanged();
                }
            }
        }

        public override Money TotalPlannedActiveExpenses
        {
            get { return _totalPlannedActiveExpenses; }
            set
            {
                if (_totalPlannedActiveExpenses != value)
                {
                    _totalPlannedActiveExpenses = value;
                    OnPropertyChanged();
                }
            }
        }

        public override Money TotalPlannedAllExpenses
        {
            get { return _totalPlannedAllExpenses; }
            set
            {
                if (_totalPlannedAllExpenses != value)
                {
                    _totalPlannedAllExpenses = value;
                    OnPropertyChanged();
                }
            }
        }

        public override Money TotalIncomes
        {
            get { return _totalIncomes; }
            set
            {
                if (_totalIncomes != value)
                {
                    _totalIncomes = value;
                    OnPropertyChanged();
                }
            }
        }

        public override string PlanedBudgetTite
        {
            get { return _planedBudgetTite; }
            set
            {
                if (_planedBudgetTite != value)
                {
                    _planedBudgetTite = value;
                    OnPropertyChanged();
                }
            }
        }

        public override string IncomesTitle
        {
            get { return _incomesTitle; }
            set
            {
                if (_incomesTitle != value)
                {
                    _incomesTitle = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion

        public MainViewModel(ILog log) : base(log)
        {
        }
    }
}