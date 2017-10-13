using System;

// Флаги форматирования строк.

namespace FlagFormating
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("C format: {0:C}", 99.9);      // Вывод в денежном формате.
            Console.WriteLine("F format: {0:##}", 99.935);   // Вывод значений с фиксированой точностью.
            Console.WriteLine("N format: {0:N}", 99999);     // Стандартное числовое форматироваание.
            Console.WriteLine("X format: {0:X}", 255);       // Вывод в шеснадцатиричном формате.
            Console.WriteLine("D format: {0:D}", 0xFF);      // Вывод в десятичном формате.
            Console.WriteLine("E format: {0:E}", 9999);      // Вывод в экспоненциальном формате.
            Console.WriteLine("G format: {0:G}", 99.9);      // Вывод в общем формате.
            Console.WriteLine("P format: {0:P}", 99.9);      // Вывод в процентном формате.
            
            // Delay.
            Console.ReadKey();
        }
    }
}
