using System;

// Методы с изменяемыми параметрами (ref = in/out).

namespace Methods
{
    class Program
    {
        // Если в теле метода выполнится изменение значения переменной переданной по ссылке,
        // ее значение будет изменено везде

        static int Method(ref int a)
        {
            int b = a * 2;
            a = 5;
            return b;
        }

        static void Main()
        {
            int operand = 2;

            int result = Method(ref operand);

            Console.WriteLine("{0}; {1};", operand, result);

            // Delay.
            Console.ReadKey();
        }
    }
}
