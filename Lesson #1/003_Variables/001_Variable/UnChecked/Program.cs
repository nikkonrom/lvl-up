using System;

// Запрет проверки переполнения - (unchecked)

namespace UnChecked
{
    class Program
    {
        static void Main()
        {
            sbyte a = 127;

            // Проверять переполнение.
            unchecked
            {
                a++; // Логическая ошибка
            }

            // 127 + 1 = -128
            Console.WriteLine(a);

            // Delay.
            Console.ReadKey();
        }
    }
}
