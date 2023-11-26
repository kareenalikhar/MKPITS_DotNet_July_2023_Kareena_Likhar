using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_declaration_ILogger
{
    interface ILogger
    {
        string LogMessage(string message);
        string LogError(string error);
    }
    class consoleLogger:ILogger
    {
        public string LogMessage(string message)
        {
            return "Hello from LogMessage: ";
        }
        public string LogError(string error)
        {
            return "Hello from LogError: ";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger l;
            l=new consoleLogger();
            string res=l.LogMessage("LogMessage");
            Console.WriteLine(res);
            string res1=l.LogError("LogError");
            Console.WriteLine(res1);
            Console.ReadLine();
            
        }
    }
}
