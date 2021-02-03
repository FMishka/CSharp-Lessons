using System;
using System.Collections.Generic;
using System.Text;

namespace Partial
{
    partial class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public partial string GetFullName();
    }
}
