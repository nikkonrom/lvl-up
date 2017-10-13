using System;

// Тернарная условная операция.

namespace Condition
{
    class Program
    {
        static void Main()
        {
            int a = 1, b = 2, c = -5, max = 0;

            max = a > b ? c = a : c = b; // сначала с = а, а только потом max = c 

            Console.WriteLine(max);
            Console.WriteLine(c);

            // Delay.
            Console.ReadKey();
        }
    }
}
