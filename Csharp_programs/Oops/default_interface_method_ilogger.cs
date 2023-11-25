using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace default_interface_method_ilogger
{
    interface ILogger
    {
        string LogMessage(string message);
        string LogError(string error);

        string LogInfo(string infoMessage);
    }
    class consoleLogger : ILogger
    {
        public string LogMessage(string message)
        {
            return "Hello from LogMessage: ";
        }
        public string LogError(string error)
        {
            return "Hello from LogError: ";
        }
        public string LogInfo(string infoMessage)
        {
            return "Hello from LogInfo: ";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger l;
            l = new consoleLogger();
            string res = l.LogMessage("LogMessage");
            Console.WriteLine(res);
            string res1 = l.LogError("LogError");
            Console.WriteLine(res1);
            string res2 = l.LogInfo("LogInfo");
            Console.WriteLine(res2);
            Console.ReadLine();

        }
    }
}
