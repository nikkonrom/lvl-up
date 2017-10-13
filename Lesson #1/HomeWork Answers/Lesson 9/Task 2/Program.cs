using System;

namespace Task_2
{
    class Program
    {
        static int[] MyReverse(int[] array)
        {
            int buf = 0;
            int n = array.Length;
            int j = n - 1;

            for (int k = 0; k < j; k++)
            {
                buf = array[k];
                array[k] = array[j];
                array[j] = buf;
                j--;
            }

            return array;
        }

        static int[] SubArray(int[] array, int index, int count)
        {
            int[] array1 = new int[count];
            int k = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array.Length > index)
                {
                    array1[k] = array[index];
                }
                else
                {
                    array1[k] = 1;
                }

                index++;
                k++;
            }

            return array1;
        }

        static void Main()
        {
            int[] array = new int[10];

            // Заполнение массива.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 2;
            }


            Console.Write("Введите индекс массива:");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество елементов:");
            int count = Convert.ToInt32(Console.ReadLine());

            array = SubArray(array, index, count);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }

            array = new int[10];

            // Заполнение массива.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 2;
            }

            array = MyReverse(array);

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
