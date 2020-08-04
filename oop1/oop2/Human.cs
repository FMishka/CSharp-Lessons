using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        protected int intelligence, power, agility;
        //Инициализация характеристик человека
        public void initSpec()
        {
            Random randSpec = new Random();
            intelligence = randSpec.Next(100);
            power = randSpec.Next(100);
            agility = randSpec.Next(100);
        }

        public int getInt
        {
            get
            {
                return intelligence;
            }
        }
        public int getPower
        {
            get
            {
                return power;
            }
        }
        public int getAgility
        {
            get
            {
                return agility;
            }
        }
        public void printSpec()
        {
            Console.WriteLine("Intelligence: " + intelligence);
            Console.WriteLine("Power: " + power);
            Console.WriteLine("Agility: " + agility);
        }
    }
}
