using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PJRLoggingUtility
{
    public class Log
    {
        public DateTime EventTime { get; set; }
        public EventType EventType { get; set; } 
        public string Source { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
    }

    public enum EventType
    {
        Info=1,
        Error=2,
        Warning=3,
        Fatal =4
    }
}
