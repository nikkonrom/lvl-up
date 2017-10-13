using System;

// Перегрузка методов. 

namespace Methods
{
    class Program
    {
        static void Operation()                                         // 1-я перегрузка.
        {
            Operation("val", 10, 12.2);
        }

        static void Operation(string value1)                            // 2-я перегрузка.
        {
            Operation(value1, 10, 12.2);
        }

        static void Operation(string value1, int value2)                // 3-я перегрузка.
        {
            Operation(value1, value2, 12.2);
        }

        static void Operation(string value1, int value2, double value3) // 4-я перегрузка.
        {
            Console.WriteLine("{0},{1},{2}", value1, value2, value3);
        }

        static void Main()
        {
            Operation();                  // 1-я перегрузка.
            Operation("val");             // 2-я перегрузка.
            Operation("val", 10);         // 3-я перегрузка. 
            Operation("val", 10, 12.2);   // 4-я перегрузка.
            
            // Delay.
            Console.ReadKey();
        }
    }
}
