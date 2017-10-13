using System;

// Циклическая конструкция - do-while.

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
            }
            while (counter < 3);

            Console.WriteLine("Произведено {0} итераций.", counter);

            // Delay.
            Console.ReadKey();
        }
    }
}
