using System;

// Сравнение значений разных типов.

namespace Comparison
{
    class Program
    {
        static void Main()
        {
            bool result = false;

            int a = 1;
            float b = 2.0f;
            result = a < b;   // Сравнение значения типа int, со значением типа float - допустимо.

            string c = "Hello";
            //result = c < a; // Сравнение значения типа int, со значением типа string - не допустимо.

            // Delay.
            Console.ReadKey();
        }
    }
}
