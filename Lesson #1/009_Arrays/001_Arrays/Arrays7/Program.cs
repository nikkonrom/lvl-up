using System;

// Массивы (двумерный массив).

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            int[,] array = new int[3, 3];
             
            array[0, 0] = 1;
            array[0, 1] = 2;
            array[0, 2] = 3;

            array[1, 0] = 4;
            array[1, 1] = 5;
            array[1, 2] = 6;

            array[2, 0] = 7;
            array[2, 1] = 8;
            array[2, 2] = 9;
             
            Console.Write(array[0, 0]);
            Console.Write(array[0, 1]);
            Console.Write(array[0, 2]);
            Console.Write("\n");
            Console.Write(array[1, 0]);
            Console.Write(array[1, 1]);
            Console.Write(array[1, 2]);
            Console.Write("\n");
            Console.Write(array[2, 0]);
            Console.Write(array[2, 1]);
            Console.Write(array[2, 2]);
                       
            // Delay.
            Console.ReadKey();
        }
    }
}
