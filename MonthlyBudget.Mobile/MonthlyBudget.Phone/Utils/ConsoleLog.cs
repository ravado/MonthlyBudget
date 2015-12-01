using System;
using MonthlyBudget.Common.Services;

namespace MonthlyBudget.Phone.Utils
{
    public class ConsoleLog:ILog
    {
        public void Debug(string message, LogLevel lvl, string caller)
        {
            throw new NotImplementedException();
        }

        public void Debug(string message, LogLevel lvl, Exception ex, string caller)
        {
            throw new NotImplementedException();
        }

        public void Info(string message, LogLevel lvl, string caller)
        {
            throw new NotImplementedException();
        }

        public void Info(string message, LogLevel lvl, Exception ex, string caller)
        {
            throw new NotImplementedException();
        }

        public void Warning(string message, LogLevel lvl, string caller)
        {
            throw new NotImplementedException();
        }

        public void Warning(string message, LogLevel lvl, Exception ex, string caller)
        {
            throw new NotImplementedException();
        }

        public void Error(string message, LogLevel lvl, string caller)
        {
            throw new NotImplementedException();
        }

        public void Error(string message, LogLevel lvl, Exception ex, string caller)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message, LogLevel lvl, string caller)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message, LogLevel lvl, Exception ex, string caller)
        {
            throw new NotImplementedException();
        }
    }
}
