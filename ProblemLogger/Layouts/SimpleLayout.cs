using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemLogger.Enums;
using ProblemLogger.Interfaces;

namespace ProblemLogger.Layouts
{
    public class SimpleLayout:ILayout
    {
        public string FormatMessage(string dateTime, ReportLevel reportLevel, string message)
        {
            return $"{dateTime} - {reportLevel.ToString().ToUpper()} - {message}";
        }
    }
}