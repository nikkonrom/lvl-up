using System;

// Циклическая конструкция - while. (с пропуском итерации - continue)

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

                continue;

                Console.WriteLine("Эта строка не выполнится.");
            }

            Console.WriteLine("Произведено {0} итераций.", counter);

            // Delay.
            Console.ReadKey();
        }
    }
}
