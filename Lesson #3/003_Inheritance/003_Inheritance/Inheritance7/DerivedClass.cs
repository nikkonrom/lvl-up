using System;

namespace Inheritance
{
    class DerivedClass : BaseClass
    {
        // Переопределение метода базового класса.

        public override void Method()
        {
            Console.WriteLine("Method from DerivedClass");
        }
    }
}
