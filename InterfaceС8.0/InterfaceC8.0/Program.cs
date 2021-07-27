using System;

namespace InterfaceC8._0
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.Log(LogLevel.Debug, "Debug");
            logger.Log(LogLevel.Info, "Info");
            logger.Log(LogLevel.Warning, "Warning");
            logger.Log(LogLevel.Error, "Error");
            logger.Log(LogLevel.Fatal, "Fatal");
            logger.Foo();
        }
    }
}
