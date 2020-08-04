using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    class Driver : Human
    {
        public void checkInt()
        {
            if (getInt <= 80)
            {
                Console.WriteLine(Name + " - немного туповат");
            }
            else
            {
                Console.WriteLine(Name + " - умный");
            }
        }

        public void Drive()
        {
            Console.WriteLine("ПОИХАЛЫ!!!1!!1");
        }
    }
}
