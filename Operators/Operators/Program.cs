using System;

namespace Operators
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

        public static int operator +(Point dot1, Point dot2)
        {
            return dot1.X + dot2.X;
        }
        public static bool operator ==(Point dot1, Point dot2)
        {
            int sumIndex1 = dot1.X + dot1.Y;
            int sumIndex2 = dot2.X + dot2.Y;
            return sumIndex1 == sumIndex2;
        }
        public static bool operator !=(Point dot1, Point dot2)
        {
            int sumIndex1 = dot1.X + dot1.Y;
            int sumIndex2 = dot2.X + dot2.Y;
            return sumIndex1 != sumIndex2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1,2);
            Point point2 = new Point(3, 4);

            int sumX = point1 + point2;
            Console.WriteLine(sumX);

            bool isEqually = point1 == point2;
            bool isNotEqually = point1 != point2;
            Console.WriteLine($"Равно: {isEqually}");
            Console.WriteLine($"Не равно: {isNotEqually}");

        }
    }
}
