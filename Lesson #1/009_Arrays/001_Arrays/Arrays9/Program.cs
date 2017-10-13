using System;

// Массивы (двумерный массив).

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            // Компилятор определяет размер массива на основании выражения инициализации.
            int[,] array = {
                             { 1, 2, 3 },
                             { 4, 5, 6 },
                             { 7, 8, 9 }
                           };

            Console.WriteLine(array);
            

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
