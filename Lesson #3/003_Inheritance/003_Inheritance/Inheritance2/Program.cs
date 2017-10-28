using System;

// Наследование. 

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass();

            Console.WriteLine(instance.publicField);

            instance.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}
