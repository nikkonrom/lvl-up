using System;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число:");
            double x = Convert.ToDouble(Console.ReadLine());

            if ((x >= 0) && (x <= 14))
            {
                Console.WriteLine("Число входит в промежуток [0 - 14]");
            }
            else if ((x >= 15) && (x <= 35))
            {
                Console.WriteLine("Число входит в промежуток [15 - 35]");
            }
            else if ((x >= 36) && (x <= 50))
            {
                Console.WriteLine("Число входит в промежуток [36 - 50]");
            }
            else if ((x >= 50) && (x <= 100))
            {
                Console.WriteLine("Число входит в промежуток [50 - 100]");
            }
            else
            {
                Console.WriteLine("Число не входит ни в один из существующих промежутков.");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
