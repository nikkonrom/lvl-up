using System;

namespace Task_3
{
    class Program
    {
        static void IncreaseArray(ref int[] array)
        {
            int[] tempArray = new int[array.Length + 1];

            for (int i = 0; i < array.Length + 1; i++)
            {
                if (i <= array.Length - 1)
                {
                    tempArray[i] = array[i];
                }
                else
                {
                    tempArray[i] = 0;
                }
            }

            array = tempArray;
        }

        static int[] ChangeArray(int[] array, int value)
        {
            int[] tempArray = new int[(array.Length + 1)];

            for (int i = 0; i < array.Length + 1; i++)
            {
                if (i == 0)
                {
                    tempArray[i] = value;
                }
                if ((i > 0) && (i <= array.Length))
                {
                    tempArray[i] = array[i - 1];
                }
            }

            return tempArray;
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }

        static void Main()
        {
            Console.Write("Введите количество элементов массива: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            PrintArray(array);
            IncreaseArray(ref array);
            PrintArray(array);

            int[] array2 = ChangeArray(array, 99);
            PrintArray(array2);

            // Delay.
            Console.ReadKey();
        }
    }
}
