using System;

// Операции сравнения и проверки на равенство (<, <=, >, >=, ==, !=)

namespace Comparison
{
    class Program
    {
        static void Main()
        {
            byte value1 = 0, value2 = 1;
            bool result = false;

            // Less than
            result = value1 < value2;
            Console.WriteLine(result);

            // Greater than
            result = value1 > value2;
            Console.WriteLine(result);

            // Less than or equal to
            result = value1 <= value2;
            Console.WriteLine(result);

            // Greater than or equal to
            result = value1 >= value2;
            Console.WriteLine(result);

            // Equals
            result = value1 == value2;
            Console.WriteLine(result);

            // Not equals
            result = value1 != value2;
            Console.WriteLine(result);

            // Delay.
            Console.ReadKey();
        }
    }
}
