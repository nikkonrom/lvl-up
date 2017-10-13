using System;

// Арифметические операторы (Arithmetic Operators) - +, −, *, /, %

namespace Arithmetic
{
    class Program
    {
        static void Main()
        {
            // Addition (+) 
            byte summand1 = 1, summand2 = 2; // Множественное объявление.
            int sum = 0;
            sum = summand1 + summand2;
            
            Console.WriteLine(sum);

            // Subtraction (-)
            byte minuend = 5, subtrahend = 3;
            int difference = 0;
            difference = minuend - subtrahend;
            
            Console.WriteLine(difference);

            // Multiplication (*)
            byte factor1 = 2, factor2 = 3;
            int product = 0;
            product = factor1 * factor2;
            
            Console.WriteLine(product);

            // Division (/)
            byte dividend = 5, divisor = 2;
            int quotient = 0, remainder = 0;
            quotient = dividend / divisor;

            Console.WriteLine(quotient);

            // Remainder after division (%)
            remainder = dividend % divisor;

            Console.WriteLine(remainder);
 
            // Delay.
            Console.ReadKey();
        }
    }
}
