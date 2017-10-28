using System;

// Приведение к базовому типу.

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();

            // UpCast
            BaseClass instanceUp = instance;
            instanceUp.Method();

            // DownCast
            DerivedClass instanceDown = (DerivedClass)instanceUp;
            instanceDown.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
