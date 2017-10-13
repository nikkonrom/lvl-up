using System;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            double x = 10, y = 15, z = 20, rez = 0;
            rez = (x + y + z) / 3;
            Console.WriteLine("Среднее арифметическое чисел {0}, {1} и {2} равно {3}", x, y, z, rez);

            // Delay.
            Console.ReadKey();
        }
    }
}
