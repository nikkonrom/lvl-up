using System;

// Циклическая конструкция - while. (с досрочным выходом из цикла - break)

namespace Loop
{
    class Program
    {
        static void Main()
        {
            int counter = 0;

            while (counter < 3)
            {
                counter++;
                Console.WriteLine("Counter {0}", counter);

                break;

                Console.WriteLine("Эта строка не выполнится.");
            }

            Console.WriteLine("Произведено {0} итераций.", counter);

            // Delay.
            Console.ReadKey();
        }
    }
}
