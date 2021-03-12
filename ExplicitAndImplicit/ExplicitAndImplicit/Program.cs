using System;

namespace ExplicitAndImplicit
{
    class Timer
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
    }
    class Counter
    {
        public int Seconds { get; set; }
        static public implicit operator Counter(int x)
        {
            return new Counter { Seconds = x };
        }
        static public explicit operator int(Counter x)
        {
            return x.Seconds;
        }
        static public explicit operator Counter(Timer x)
        {
            int hours = x.Hours;
            int minutes = x.Minutes;
            int seconds = x.Seconds;
            return new Counter { Seconds = hours * 3600 + minutes * 60 + seconds};
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 55;
            Counter counter = a;
            int b = (int)counter;
            Console.WriteLine("Counter:" + counter.Seconds);
            Console.WriteLine("Int: " + b);
            Timer timer = new Timer { Hours = 1, Minutes = 30, Seconds = 15 };
            Counter counter1 = (Counter)timer;
            Console.WriteLine("Counter1: " + counter1.Seconds);
        }
    }
}
