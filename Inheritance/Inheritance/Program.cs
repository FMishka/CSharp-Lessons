using System;

namespace Inheritance
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void PrintName()
        {
            Console.WriteLine($"Имя: {FirstName}; Фамилия: {LastName}");
        }
    }
    class Student:Person
    {
        public int raiting;
        public void Learning()
        {
            raiting++;
            Console.WriteLine($"Я повысил свой рейтинг - {raiting}!");
        }
    }
    class Employee:Person
    {
        public decimal Salary { get; set; }
    }
    class Teacher:Employee
    {
        public void Teach()
        {
            Console.WriteLine("Я учу!");
        }
    }
    class Programmer : Employee
    {
        public void Program()
        {
            Console.WriteLine("Я программирую!");
        }
    }
    class Program
    {
        static void PrintFullName(Person person)
        {
            Console.WriteLine($"Фамилия: {person.FirstName}\nИмя: {person.LastName}");
        }
        static void Main(string[] args)
        {
            Person person = new Person { FirstName = "Иван", LastName = "Иванов" };
            person.PrintName();

            Student student = new Student { FirstName = "Пётр", LastName = "Петров" };
            student.PrintName();
            student.Learning();
            Console.WriteLine();
            PrintFullName(person);
            Console.WriteLine();
            PrintFullName(student);
            Console.WriteLine();

            Person[] people = { person, student };
            foreach (var item in people)
            {
                item.PrintName();
            }
        }
    }
}
