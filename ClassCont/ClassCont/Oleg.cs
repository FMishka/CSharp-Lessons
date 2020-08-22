using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCont
{
    static class Oleg
    {
        //По умолчанию стоит private
        public static class Name
        {
            private static string FirstName()
            {
                return "Олег";
            }
            private static string SecondName()
            {
                return "Алексеев";
            }
            public static string FullName()
            {
                return $"{FirstName()} {SecondName()}";
            }
        }
        public static class Body
        {
            public static int ArmCount()
            {
                return 2;
            }
            public static int LegCount()
            {
                return 2;
            }
            public static int HeadCount()
            {
                return 1;
            }
        }
    }
}
