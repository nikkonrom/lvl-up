using System;

// Циклическая конструкция - do-while. (с пропуском итерации - continue)

namespace Loop
{
    class Program
    {
        static void Main()
        {
            int counter = 0;

            do
            {
                counter++;
                Console.WriteLine("Counter {0}", counter);

                continue;

                Console.WriteLine("Эта строка не выполнится.");
            }
            while (counter < 3);

            Console.WriteLine("Произведено {0} итераций.", counter);

            // Delay.
            Console.ReadKey();
        }
    }
}
