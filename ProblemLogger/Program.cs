using System;
using System.Collections.Generic;
using ProblemLogger;
using ProblemLogger.Appenders;
using ProblemLogger.Enums;
using ProblemLogger.Interfaces;
using ProblemLogger.Layouts;
using ProblemLogger.Models;
using ProblemLogger.Appenders;
using ProblemLogger.Enums;
using ProblemLogger.Interfaces;
using ProblemLogger.Layouts;
using ProblemLogger.Models;
using ProblemLogger;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<IAppender> appenders = new List<IAppender>();

        for (int i = 0; i < n; i++)
        {
            string[] appenderInfo = Console.ReadLine().Split(' ');
            string appenderType = appenderInfo[0];
            string layoutType = appenderInfo[1];
            ReportLevel reportLevel = ReportLevel.Info;

            if (appenderInfo.Length == 3)
            {
                reportLevel = Enum.Parse<ReportLevel>(appenderInfo[2], true);
            }

            ILayout layout = new SimpleLayout();

            IAppender appender = appenderType switch
            {
                "ConsoleAppender" => new ConsoleAppender(layout) { ReportLevel = reportLevel },
                "FileAppender" => new FileAppender(layout, new LogFile()) { ReportLevel = reportLevel },
                _ => throw new ArgumentException("Invalid appender type")
            };

            appenders.Add(appender);
        }

        ILogger logger = new Logger(appenders.ToArray());

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] messageParts = input.Split('|');
            ReportLevel reportLevel = Enum.Parse<ReportLevel>(messageParts[0], true);
            string dateTime = messageParts[1];
            string message = messageParts[2];

            logger.Log(dateTime, reportLevel, message);
        }

        Console.WriteLine("Logger info");
        foreach (var appender in appenders)
        {
            if (appender is FileAppender fileAppender)
            {
                Console.WriteLine($"Appender type: {appender.GetType().Name}, Layout type: {appender.Layout.GetType().Name}, Report level: {appender.ReportLevel}, Messages appended: {appender.MessagesAppended}, File size: {fileAppender.FileSize}");
            }
            else
            {
                Console.WriteLine($"Appender type: {appender.GetType().Name}, Layout type: {appender.Layout.GetType().Name}, Report level: {appender.ReportLevel}, Messages appended: {appender.MessagesAppended}");
            }
        }
    }
}

