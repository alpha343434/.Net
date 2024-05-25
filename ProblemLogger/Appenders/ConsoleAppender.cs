using ProblemLogger.Enums;
using ProblemLogger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemLogger.Appenders
{
    public class ConsoleAppender : IAppender
    {
        public ILayout Layout { get; private set; }
        public ReportLevel ReportLevel { get; set; }
        public int MessagesAppended { get; private set; }

        public ConsoleAppender(ILayout layout)
        {
            Layout = layout;
            ReportLevel = ReportLevel.Info;
        }

        public void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= ReportLevel)
            {
                Console.WriteLine(Layout.FormatMessage(dateTime, reportLevel, message));
                MessagesAppended++;
            }
        }
    }
}