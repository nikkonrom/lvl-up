using System;

// Наследование.

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass(1, 2);

            Console.WriteLine(instance.baseNumber);
            Console.WriteLine(instance.derivedField);

            // Delay.
            Console.ReadKey();
        }
    }
}
