using System;

// Массивы (одномерный массив).

namespace Arrays
{
    class Program
    {
        static void Main()
        {

            // На 14 строке создаем массив целочисленных элементов с именем array размерностью в 5 элементов

            int[] array = new int[5];

            // На 18 строке элементу массива array по индексу 0 присваиваем значение 10

            array[0] = 10;
            array[1] = 20;
            array[2] = 30;
            array[3] = 40;
            array[4] = 50;

            // На 26 строке выводим на экран значение элемента массива array по индексу 0

            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);

            // Delay.
            Console.ReadKey();
        }
    }
}
