using System;

namespace ConsoleAppInheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(100, "Green", new DateTime(2023, 12, 10));
            Shape s = new Circle(1520, "Red", new DateTime(2023, 12, 10));
            Shape r = new Ractangle();

            Console.WriteLine(s);
        }
    }
}
