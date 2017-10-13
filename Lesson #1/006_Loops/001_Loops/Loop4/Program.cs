using System;

// Циклическая конструкция - while.

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
            }

            Console.WriteLine("Произведено {0} итераций.", counter);

            // Delay.
            Console.ReadKey();
        }
    }
}
