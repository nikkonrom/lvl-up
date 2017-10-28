using System;

namespace Inheritance
{
    class DerivedClass : BaseClass
    {
        // Замещение метода базового класса.

        public void Method()
        {
            Console.WriteLine("Method from DerivedClass");
        }
    }
}
