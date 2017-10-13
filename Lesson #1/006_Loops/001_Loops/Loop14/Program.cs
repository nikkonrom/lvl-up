using System;

// Циклическая конструкция (цикл со счетчиком) - for (с пропуском итерации - continue).

namespace Loop
{
    class Program
    {
        static void Main()
        {

            for (int counter = 0; counter < 3; counter++)
            {
                Console.WriteLine("Counter = {0}", counter);

                continue;

                Console.WriteLine("Эта строка не выполнится.");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
