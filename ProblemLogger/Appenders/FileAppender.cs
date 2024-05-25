using ProblemLogger.Enums;
using ProblemLogger.Interfaces;
using ProblemLogger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemLogger.Appenders
{
    public class FileAppender : IAppender
    {
        public ILayout Layout { get; private set; }
        public ReportLevel ReportLevel { get; set; }
        private LogFile logFile;

        public int MessagesAppended { get; private set; }

        public FileAppender(ILayout layout, LogFile logFile)
        {
            Layout = layout;
            this.logFile = logFile;
            ReportLevel = ReportLevel.Info;
        }

        public void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= ReportLevel)
            {
                string formattedMessage = Layout.FormatMessage(dateTime, reportLevel, message);
                logFile.Write(formattedMessage);
                MessagesAppended++;
            }
        }

        public int FileSize => logFile.Size;
    }
}