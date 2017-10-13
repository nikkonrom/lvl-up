using System;

// Массивы (четырехмерный массив).

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            int[, , ,] array = 
            {
              {
                { { 0x0, 0x1 }, {0x2, 0x3 } },
                { { 0x4, 0x5 }, {0x6, 0x7 } }
              },
              {
                { { 0x8, 0x9 }, {0xA, 0xB } },
                { { 0xC, 0xD }, {0xE, 0xF } }
              }
            };


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        for (int l = 0; l < 2; l++)
                        {
                            Console.Write("{0:X} ", array[i, j, k, l]);
                        }
                        Console.Write("\n");
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
