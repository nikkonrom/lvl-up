using System;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число клиентов:");
            int x = Convert.ToInt32(Console.ReadLine());

            int result = 1;

            do
            {
                result *= x--;

            } while (x > 0);

            Console.WriteLine("Количество вариантов доставки: {0}", result);

            // Delay.
            Console.ReadKey();
        }
    }
}
