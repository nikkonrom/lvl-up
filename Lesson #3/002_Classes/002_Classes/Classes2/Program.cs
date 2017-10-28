using System;

// Частичные методы (Partial methods).

namespace Classes
{
    class Program
    {
        static void Main()
        {
            PartialClass instance = new PartialClass();

            instance.CallPartialMethod();
            
            // Delay.
            Console.ReadKey();
        }
    }
}
