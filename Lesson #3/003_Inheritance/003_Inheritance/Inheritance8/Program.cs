using System;

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();
            
            // Delay.
            Console.ReadKey();
        }
    }
}
