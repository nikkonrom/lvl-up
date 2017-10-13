using System;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            const float pi = 3.141f;
            int r = 15;
            Console.WriteLine("Площадь круга {0}", (float)(pi * r * r));

            // Delay.
            Console.ReadKey();
        }
    }
}
