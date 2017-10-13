using System;

// Массивы (одномерный массив).

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            // На 14 строке создаем массив целочисленных элементов с именем array размерностью в 5 элементов
            // в блоке инициализатора заполняем его значениями 1,2,3,4,5
            
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
                        
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
