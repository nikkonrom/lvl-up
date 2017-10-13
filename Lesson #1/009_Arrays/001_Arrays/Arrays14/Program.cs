using System;

// Массивы (трехмерный массив).

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            int[, ,] array = 
            { 
               { { 1, 2, 3 }, { 4, 5, 6 }, {7, 8, 9} }, 
               { { 1, 2, 3 }, { 4, 5, 6 }, {7, 8, 9} }, 
               { { 1, 2, 3 }, { 4, 5, 6 }, {7, 8, 9} }                                  
            };

           
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write("{0} ", array[i, j, k]);
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
