using System;

namespace Interfaces
{
    interface IDataProvider
    {
        public string GetData();
    }
    interface IDataProcessor
    {
        public void ProcessData(IDataProvider dataProvider);
    }

    class ConsoleDataProcessor : IDataProcessor
    {
        public void ProcessData(IDataProvider dataProvider)
        {
            Console.WriteLine(dataProvider.GetData());
        }
    }

    class DbDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из бд";
        }
    }

    class FileDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из файла";
        }
    }

    class APIDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из апи";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IDataProcessor dataProcessor = new ConsoleDataProcessor();
            dataProcessor.ProcessData(new DbDataProvider());
            dataProcessor.ProcessData(new FileDataProvider());
            dataProcessor.ProcessData(new APIDataProvider());
        }
    }
}
