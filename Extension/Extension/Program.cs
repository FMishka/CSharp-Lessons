using System;
using MyExtension;

namespace Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            dateTime.Print();
            Console.WriteLine(dateTime.IsWeekend(dateTime.DayOfWeek));
        }
    }
}
