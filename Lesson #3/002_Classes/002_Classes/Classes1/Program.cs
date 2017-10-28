using System;

// Частичные классы (Partial classes).

namespace Classes
{
    class Program
    {
        static void Main()
        {
            PartialClass instance = new PartialClass();

            instance.MethodFromPart1(); // Метод из первой части класса PartialClass
            instance.MethodFromPart2(); // Метод со второй части класса PartialClass.

            // Delay.
            Console.ReadKey();
        }
    }
}
