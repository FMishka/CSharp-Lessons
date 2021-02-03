using System;
using System.Collections.Generic;
using System.Text;

namespace MyExtension
{
    static class Extension
    {
        static public void Print(this DateTime dateTime)
        {
            Console.WriteLine(dateTime);
        }
        static public bool IsWeekend(this DateTime dateTime, DayOfWeek dayOfWeek)
        {
            if (DayOfWeek.Saturday == dayOfWeek || DayOfWeek.Sunday == dayOfWeek)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
