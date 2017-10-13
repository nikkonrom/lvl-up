using System;

// Выбор между типами float, double, decimal

namespace FloatDoubleDecimal
{
    class Program
    {
        static void Main()
        {
            float variable1 = 0.12345678901234567890f;
            double variable2 = 0.12345678901234567890d;
            decimal variable3 = 0.12345678901234567890m;

            Console.WriteLine(variable1);
            
            Console.WriteLine(variable2);
            
            Console.WriteLine(variable3);

            Console.ReadKey();
        }
    }
}
