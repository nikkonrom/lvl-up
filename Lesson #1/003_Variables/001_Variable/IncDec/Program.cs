using System;

// Операторы Инкремента и Декремента (Increment and Decrement Operators)

namespace IncDec
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("----- Постфиксный инкремент"); // Post-increment
            
            byte number1 = 0;            
            Console.WriteLine(number1++); // Сначала выводим на экран, потом увеличиваем на 1.
            Console.WriteLine(number1);

            Console.WriteLine("----- Префиксный инкремент"); // Pre-increment

            byte number2 = 0;
            Console.WriteLine(++number2); // Сначала увеличиваем на 1, потом выводим на экран.

            Console.WriteLine("----- Постфиксный декремент"); // Post-decrement

            sbyte number3 = 0;
            Console.WriteLine(number3--); // Сначала выводим на экран, потом уменьшаем на 1.
            Console.WriteLine(number3);

            Console.WriteLine("----- Префиксный декремент"); // Pre-decrement

            sbyte number4 = 0;
            Console.WriteLine(--number4); // Сначала уменьшаем на 1, потом выводим на экран.

            // Delay.
            Console.ReadKey();
        }
    }
}
