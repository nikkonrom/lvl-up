using System;

namespace AdditionTask
{
    class Program
    {
        static void Main()
        {
            int s = 0;
            Console.WriteLine("Введите число для проверки:");
            int x = Convert.ToInt32(Console.ReadLine());
            s = x & (x - 1);

            if (s == 0)
            {
                Console.WriteLine("Число являеться степенью двойки.");
            }
            else
            {
                Console.WriteLine("Число не являеться степенью двойки.");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
