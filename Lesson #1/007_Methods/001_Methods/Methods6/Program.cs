using System;

// Методы (Функции). 

namespace Methods
{
    class Program
    {
        // Методы, которые возвращают логическое значение, называют методами-предикатами.

        static bool And(bool a, bool b)
        {
            return a && b;
        }

        static void Main()
        {
            bool operand1 = true, operand2 = true;

            bool result = And(operand1, operand2);

            Console.WriteLine("{0} && {1} = {2}", operand1, operand2, result);

            // Delay.
            Console.ReadKey();
        }
    }
}
