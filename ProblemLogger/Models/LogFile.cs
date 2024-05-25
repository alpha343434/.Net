using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemLogger.Models
{
    public class LogFile
    {
        private StringBuilder content;
        public LogFile()
        {
            content = new StringBuilder();
        }
        public void Write(string message)
        { content.AppendLine(message); }

        public int Size
        {
            get
            {
                int size = 0;
                foreach (char c in content.ToString())
                {
                    if (char.IsLetter(c))
                    {
                        size += c;
                    }
                }
                return size;
            }
        }
    }
}
