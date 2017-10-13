using System;

// Циклическая конструкция - do-while. (с досрочным выходом из цикла - break)

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

                break;

                Console.WriteLine("Эта строка не выполнится.");
            }
            while (counter < 3) ;

            Console.WriteLine("Произведено {0} итераций.", counter);

            // Delay.
            Console.ReadKey();
        }
    }
}
