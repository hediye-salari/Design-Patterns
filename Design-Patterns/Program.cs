using Design_Patterns.SingletonPattern;

class Program
{
    static void Main(string[] args)
    {
        
        Logger logger1 = Logger.GetInstance();
        logger1.Log("This is the first log.");

        
        Logger logger2 = Logger.GetInstance();
        logger2.Log("This is the second log.");

        
        logger1.PrintLogs();
    }
}
