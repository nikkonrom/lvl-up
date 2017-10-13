using System;

namespace Task_4
{
    class Program
    {
        static void Main()
        {
            const float pi = 3.141f;
            int r = 15, // радиус
                h = 14; // высота

            Console.WriteLine("Объем цилиндра {0}", (pi * r * r * h));
            Console.WriteLine("Площадь поверхности цилиндра {0}", (2 * pi * r * (r + h)));

            // Delay.
            Console.ReadKey();
        }
    }
}
