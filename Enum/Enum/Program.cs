using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void IsWeekend(TheWeek dayOfWeek)
        {
            if (dayOfWeek == TheWeek.Saturday || dayOfWeek == TheWeek.Sunday)
            {
                Console.WriteLine($"{TheWeekInRussian(dayOfWeek)} - Выходной день");
            }
            else
            {
                Console.WriteLine($"{TheWeekInRussian(dayOfWeek)} - Рабочий день");
            }
        }
        static string TheWeekInRussian(TheWeek dayOfWeek)
        {
            string daysInRussia = "";
            switch (dayOfWeek)
            {
                case TheWeek.Monday:
                     daysInRussia = "Понедельник";
                     break;
                case TheWeek.Tuesday:
                    daysInRussia = "Вторник";
                    break;
                case TheWeek.Wednesday:
                    daysInRussia = "Среда";
                    break;
                case TheWeek.Thursday:
                    daysInRussia = "Четверг";
                    break;
                case TheWeek.Friday:
                    daysInRussia = "Пятница";
                    break;
                case TheWeek.Saturday:
                    daysInRussia = "Суббота";
                    break;
                case TheWeek.Sunday:
                    daysInRussia = "Воскресенье";
                    break;
             
            }
            return daysInRussia;
        }
        static void Main(string[] args)
        {
            IsWeekend(TheWeek.Sunday);
            IsWeekend(TheWeek.Monday);
            IsWeekend((TheWeek)6);
            IsWeekend((TheWeek)2);
            Console.WriteLine();
            for (int i = 1; i <= 7; i++)
            {
                IsWeekend((TheWeek)i);
            }
        }
    }
}
