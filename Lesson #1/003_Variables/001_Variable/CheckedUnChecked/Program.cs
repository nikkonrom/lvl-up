using System;

// Комбинация проверки и запрета проверки переполнения.

namespace CheckedUnChecked
{
    class Program
    {
        static void Main()
        {
            sbyte a = 126;
            sbyte b = 127;

            // Проверять переполнение.
            checked
            {
                a++;

                // Не проверять переполнение.
                unchecked
                {
                    b++; 
                }

                a++;
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
