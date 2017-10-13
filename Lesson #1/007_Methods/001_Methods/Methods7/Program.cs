using System;

// Пример правильного множественного возврата из метода.

namespace Methods
{
    class Program
    {
        static string Compare(int value1, int value2)
        {
            if (value1 < value2)
            {
                return "Comparison Less Then";
            }
            else if (value1 > value2)
            {
                return "Comparison Greater Then";
            }

            return "Comparison Equal";
        }

        static void Main()
        {
            int operand1 = 1, operand2 = 2;

            string result = Compare(operand1, operand2);

            Console.WriteLine(result);

            // Delay.
            Console.ReadKey();
        }
    }
}
