using System;

// Ключевое слово params, позволяет определить параметр метода, принимающий переменное количество аргументов.

namespace Arrays
{
    class Program
    {
        static void ShowArray(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
        
        static void Main()
        {
            ShowArray(0, 1, 2, 3, 4, 5, 6, 7, 8, 9);

            // Delay.
            Console.ReadKey();
        }
    }
}
