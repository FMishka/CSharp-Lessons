using System;

namespace ISandAs
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Print()
        {
            Console.WriteLine($"X = {X}; Y = {Y}");
        }
    }
    class Program
    {
        static void Foo(object obj)
        {
            Point p = obj as Point;

            if (p != null)
            {
                p.Print();
            }
            else
            {
                Console.WriteLine("Преобразование не удалось!");
            }
        }
        static void Bar(object obj)
        {
            if (obj is Point point)
            {
                point.Print();
            }
            else
            {
                Console.WriteLine("Объект не точка!");
            }
        }
        static void Main(string[] args)
        {
            object obj = new Point(5, 12);
            Point point = (Point)obj;
            point.Print();
            object obj1 = "1234";
            Foo(obj);
            Foo(obj1);
            Bar(obj);
            Bar(obj1);
        }
    }
}
