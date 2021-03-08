using System;

namespace BASE
{
    class Point2D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine("Вызван конструктор Point2D");
        }
        public void Print()
        {
            Console.WriteLine("X = " + X);
            Console.WriteLine("Y = " + Y);
        }
    }
    class Point3D : Point2D
    {
        public int Z { get; set; }
        public Point3D(int x, int y, int z):base(x,y)
        {
            Z = z;
            Console.WriteLine("Вызван конструктор Point3D");
        }
        public void Print()
        {
            base.Print();
            Console.WriteLine("Z = " + Z);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point3D point = new Point3D(1,2,3);
            point.Print();
        }
    }
}
