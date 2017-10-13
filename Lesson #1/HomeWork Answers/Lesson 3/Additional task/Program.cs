using System;

namespace Lesson_3
{
    class Program
    {
        static void Main()
        {
            int operand1 = 10, operand2 = 4;
            Console.WriteLine("{0} + {1} = {2}", operand1, operand2, operand1 + operand2);
            Console.WriteLine("{0} - {1} = {2}", operand1, operand2, operand1 - operand2);
            Console.WriteLine("{0} * {1} = {2}", operand1, operand2, operand1 * operand2);
            Console.WriteLine("{0} / {1} = {2}", operand1, operand2, operand1 / operand2);

            // Delay.
            Console.ReadKey();
        }
    }
}
