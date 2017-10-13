using System;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число для проверки:");
            byte x = Convert.ToByte(Console.ReadLine());
            byte n = (byte)(x << 7);

            if (n == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число не четное");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
