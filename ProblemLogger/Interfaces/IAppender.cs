using ProblemLogger.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemLogger.Interfaces
{
    public interface IAppender
    {
        ILayout Layout { get; }
        ReportLevel ReportLevel { get; set; }

        void Append(string dateTime, ReportLevel reportLevel, string message);
        int MessagesAppended {  get; }
    }
}
