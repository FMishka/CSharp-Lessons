using System;

namespace Indexer
{
    class Person
    {
        public string Name { get; set; }
        public string lastName = "This is a test lastName";
    }

    class People
    {
        Person[] data;
        public People()
        {
            data = new Person[5];
        }
        public Person this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }

        public Person this[string index]
        {
            get
            {
                Person person = null;
                foreach (var item in data)
                {
                    if (item?.Name == index)
                    {
                        person = item;
                    }
                }
                return person;
            }
        }

        public string this[string firstName, string lastName]
        {
            get
            {
                string fullName = null;
                foreach (var item in data)
                {
                    if (item.Name == firstName)
                    {
                        fullName = item.Name + " " + item.lastName;
                    }
                }
                return fullName;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
            for (int i = 0; i < 5; i++)
            {
                people[i] = new Person();
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите имя:");
                people[i].Name = Console.ReadLine();
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{people[i].Name} ");
            }
            Console.WriteLine();
            Console.WriteLine(people["Иван"].Name);
            Console.WriteLine(people["Иван", "Иванов"]);
        }
    }
}
