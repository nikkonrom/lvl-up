using System;

namespace Lessons_7
{
    class Program
    {
        static void Calculate(double operand1, double operand2, double operand3)
        {
            Console.WriteLine("Числа {0}, {1}, {2}, среднее арифметическое {3}",
                operand1, operand2, operand3, (operand1 + operand2 + operand3) / 3);
        }

        static void Main()
        {
            double operand1 = 12, operand2 = 13, operand3 = 14;

            Calculate(operand1, operand2, operand3);
            
            // Delay.
            Console.ReadKey();
        }
    }
}