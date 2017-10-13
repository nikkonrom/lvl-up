using System;

namespace Lessons_9
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[10];

            // Заполнение массива.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            // Вывод на экран значений элементов массива.
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine(new string('-', 3));

            // Вывод на экран значений элементов массива в обратном порядке.
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
