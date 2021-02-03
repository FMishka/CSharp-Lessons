using System;
using System.Collections.Generic;
using System.Text;

namespace Partial
{
    partial class Person
    {
        public partial string GetFullName()
        {
            return FirstName + " " + LastName;
        }
        public void PrintFullName()
        {
            Console.WriteLine(GetFullName());
        }
    }
}
