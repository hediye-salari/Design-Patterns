using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.SingletonPattern
{

    public class Logger
    {
        private static Logger _instance;
        private List<string> _logs;
        public Logger()
        {
            _logs=new List<string>();
        }
        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }
        public void Log(string message)
        {
            _logs.Add(message);
            Console.WriteLine($"Log: {message}");
        }

        public void PrintLogs()
        {
            {
                foreach (var log in _logs)
                {
                    Console.WriteLine(log);
                }
            }
        }


    }

}
