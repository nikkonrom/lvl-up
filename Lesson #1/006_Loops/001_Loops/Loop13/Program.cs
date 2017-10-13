using System;

// Циклическая конструкция (цикл со счетчиком) - for (с досрочным выходом из цикла - break).

namespace Loop
{
    class Program
    {
        static void Main()
        {

            for (int counter = 0; counter < 3; counter++)
            {
                Console.WriteLine("Counter = {0}", counter);

                break;

                Console.WriteLine("Эта строка не выполнится.");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
