using System;

// Тернарная условная операция. Ограничения связанные с типобезопасностью.

namespace Condition
{
    class Program
    {
        static void Main()
        {
            int a = 1;
            double b = 0.0;
            int max;

            // Выражения [?] и [:]  - должны быть одного типа.

            max = (int)((a > b) ? a : b);

            // ... или так

            max = (a > b) ? a : (int)b;

            Console.WriteLine(max);

            // Delay.
            Console.ReadKey();
        }
    }
}
