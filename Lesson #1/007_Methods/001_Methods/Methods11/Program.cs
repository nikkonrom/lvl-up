using System;

// Метод с выходными параметрами.

namespace Methods
{
    class Program
    {
        // Выходные параметры должны быть изменены в теле метода, иначе будет ошибка.
        
        static int Method(out int a)
        {
            // Закомментировать!
            a = 1;

            return 2;
        }

        static void Main()
        {
            int operand;

            // out - позволяет передавать в метод непроинициализированные переменные.
            
            int result = Method(out operand);

            Console.WriteLine("{0}; {1};", operand, result);

            // Delay.
            Console.ReadKey();
        }
    }
}
