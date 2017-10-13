using System;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите количество элементов массива: ");
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];

            int min = 0, max = 0, sa = 0;

            // Заполнение массива.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            min = array[0];
            max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 2) != 0)
                {
                    Console.WriteLine("Число не четное {0}", array[i]);
                }
                if (min > array[i])
                {
                    min = array[i];
                }
                if (max < array[i])
                {
                    max = array[i];
                }
                sa += array[i];
            }

            Console.WriteLine("Наибольший елемент {0}", max);
            Console.WriteLine("Наименьший елемент {0}", min);
            Console.WriteLine("Сумма елементов массива {0}", sa);
            Console.WriteLine("Среднее арифметическое {0}", sa / array.Length);

            // Delay.
            Console.ReadKey();
        }
    }
}
