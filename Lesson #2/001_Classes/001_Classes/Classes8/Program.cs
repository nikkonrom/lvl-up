using System;

// Конструкторы.

namespace Classes
{
    class Program
    {
        static void Main()
        {            
            Point point = new Point("A");
            Console.WriteLine("{0}.X = {1}, {0}.Y = {2}", point.Name, point.X, point.Y);

            // Delay.
            Console.ReadKey();
        }
    }
}
