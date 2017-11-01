using System;

namespace Abstraction
{
    class ConcreteDerivedClass : AbstractBaseClass
    {
        // Переопределяем виртуальный метод VirtualMethod() базового абстрактного класса.
        // Если мы не переопределим виртуальный метод, то будет использован метод из базового класса.

        public override void VirtualMethod()
        {
            Console.WriteLine("DerivedClass.VirtualMethod();");
        }

        // Реализуем абстрактный метод AbstractMethod() базового абстрактного класса.

        public override void AbstractMethod()
        {
            Console.WriteLine("DerivedClass.AbstractMethod();");
        }
    }
}
