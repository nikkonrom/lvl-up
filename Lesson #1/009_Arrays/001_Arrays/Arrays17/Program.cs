using System;

// Неявнотипизированные массивы.

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            // Массив Int32.
            var array1 = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(array1.GetType());


            // Массив Doubles.
            var array2 = new[] { 3.1415, 1, 6 };
            Console.WriteLine(array2.GetType());


            // Не компилируется. (Несовместимые типы)
            // var array3 = new [] { 1, "string" };

            // Delay.
            Console.ReadKey();
        }
    }
}
