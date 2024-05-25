using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemLogger.Enums;
using ProblemLogger.Interfaces;

namespace ProblemLogger
{
    public class Logger : ILogger
    {
        private readonly List<IAppender> appenders;

        public Logger(params IAppender[] appenders)
        {
            this.appenders = new List<IAppender>(appenders);
        }

        public void Log(string dateTime, ReportLevel reportLevel, string message)
        {
            foreach (var appender in appenders)
            {
                appender.Append(dateTime, reportLevel, message);
            }
        }

        public void Info(string dateTime, string message)
        {
            Log(dateTime, ReportLevel.Info, message);
        }

        public void Warning(string dateTime, string message)
        {
            Log(dateTime, ReportLevel.Warning, message);
        }

        public void Error(string dateTime, string message)
        {
            Log(dateTime, ReportLevel.Error, message);
        }

        public void Critical(string dateTime, string message)
        {
            Log(dateTime, ReportLevel.Critical, message);
        }

        public void Fatal(string dateTime, string message)
        {
            Log(dateTime, ReportLevel.Fatal, message);
        }
    }
}