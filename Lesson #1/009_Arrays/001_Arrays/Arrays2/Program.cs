using System;

// Массивы (одномерный массив).

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[5];

            // Заполнение массива.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 2;
            }

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
