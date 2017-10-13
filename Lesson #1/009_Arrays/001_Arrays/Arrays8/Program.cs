using System;

// Массивы (двумерный массив).

namespace Arrays
{
    class Program
    {
        static void Main()
        { 
            int[,] array = new int[3, 3];
             
            // Заполнение массива
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = i*j+1;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.Write("\n");
            }
           
            
            // Delay.
            Console.ReadKey();
        }
    }
}
