using ProblemLogger.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemLogger.Interfaces
{
    public interface ILayout
    {
        string FormatMessage(string dateTime, ReportLevel reportLevel, string message);
    }
}
