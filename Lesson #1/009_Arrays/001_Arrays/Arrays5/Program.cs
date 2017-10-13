using System;

// Массивы (одномерный массив).

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5 };


            // Вывод на экран значений элементов массива.
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
