using System;

namespace Structures2
{
    interface IPoint
    {
        void Print();
    }
    public class ClassPoint : IPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public void Print()
        {
            Console.WriteLine("ClassPoint");
            Console.WriteLine($"X = {X}\nY = {Y}");
        }
    }
    public struct StructPoint : IPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public void Print()
        {
            Console.WriteLine("StructPpoint");
            Console.WriteLine($"X = {X}\nY = {Y}");
        }
    }
    class Program
    {
        static void ForClass(ClassPoint point)
        {
            point.X++;
            point.Y++;
        }
        static void ForStruct(StructPoint point)
        {
            point.X++;
            point.Y++;
        }
        static void Main(string[] args)
        {
            ClassPoint classPoint = new ClassPoint();
            StructPoint structPoint = new StructPoint(); //Заполнение полей стандартными значениями

            ForClass(classPoint);
            ForStruct(structPoint); // Чтобы изменить значения нужно либо передать по ссылке, либо вернуть значение
            classPoint.Print();
            structPoint.Print();
        }
    }
}
//Структуры для небольших типов данных, которым полиморфизм не нужен
//В остальных случаях лучше использовать классы