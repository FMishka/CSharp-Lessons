using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @null
{
    class Person
    {
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string middleName { get; set; }


        public string GetFullName()
        {
            return $"Фамилия: {secondName}, Имя: {firstName}, Отчество: {middleName ?? "Нет данных"}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            string str = null;
            Console.WriteLine(str ?? "Нет данных");
            Person person = new Person() {firstName = "Иван", secondName = "Иванов", middleName = "Иванович"};
            Console.WriteLine(person.GetFullName());
            Person person1 = new Person() { firstName = "Иван", secondName = "Иванов"};
            Console.WriteLine(person1.GetFullName());
        }
    }
}
