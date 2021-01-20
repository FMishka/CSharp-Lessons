using System;

namespace Enum1
{
    class Program
    {
        enum Days
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                ConsoleKey key = Console.ReadKey().Key;
                int keyCode = (int)key;
                Console.WriteLine($"\tEnum {key}\tKey Code {keyCode}");
                if (key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Enter is pressed!");
                }
            }

            int value = 5;
            Days day;

            if (Enum.IsDefined(typeof(Days), value) == true)
            {
                day = (Days)value;
            }
            else
            {
                throw new Exception("Invalid Day value!");
            }
            var allDays = Enum.GetValues(typeof(Days));

            foreach (var item in allDays)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine();

            string enter = Console.ReadLine();
            Days nowDay = (Days)Enum.Parse(typeof(Days), enter, ignoreCase: true);
            Console.WriteLine(nowDay);
        }
    }
}
