using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyBudget.Common.Services
{
    public enum LogLevel
    {
        All = 0,
        Important = 1,
        Critical = 2
    }

    public interface ILog
    {
        void Debug(string message, LogLevel lvl, string caller);
        void Debug(string message, LogLevel lvl, Exception ex, string caller);

        void Info(string message, LogLevel lvl, string caller);
        void Info(string message, LogLevel lvl, Exception ex, string caller);

        void Warning(string message, LogLevel lvl, string caller);
        void Warning(string message, LogLevel lvl, Exception ex, string caller);

        void Error(string message, LogLevel lvl, string caller);
        void Error(string message, LogLevel lvl, Exception ex, string caller);

        void Fatal(string message, LogLevel lvl, string caller);
        void Fatal(string message, LogLevel lvl, Exception ex, string caller);
    }

}
