// See https://aka.ms/new-console-template for more information
namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        Logger log1 = Logger.getLoggerInstance();
        Logger log2 = Logger.getLoggerInstance();

        log1.logMessage("Message from instance 1");
        log2.logMessage("Message from Instance 2");
        //Testing Singleton Pattern Implementation
        Console.WriteLine(object.ReferenceEquals(log1, log2));

    }
}

class Logger
{
    //private static instance of Logger class
    private static Logger loggerInstance = new Logger();

    //private constructor 
    private Logger()
    {

    }

    //public static getter
    public static Logger getLoggerInstance()
    {
        return loggerInstance;
    }

    //Discreet functionality of Logger class
    public void logMessage(string message)
    {
        Console.WriteLine("Logging message:" + message);
    }
}