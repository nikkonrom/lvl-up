using System;

// Наследование абстрактных классов от интерфейсов.

namespace Interfaces
{
    interface Interface
    {
        void Method();
    }

    abstract class AbstractClass : Interface
    {
        // Замещение абстрактного метода из интерфейса, в абстрактном классе обязательно.
        public abstract void Method();      
    }

    class ConcreteClass : AbstractClass
    {
        // Реализация абстрактного метода из абстрактного класса, в конкретном классе обязательна.
        public override void Method()
        {
            Console.WriteLine("Метод - реализация интерфейса в абстрактном классе.");
        }
    }

    class Program
    {
        static void Main()
        {
            ConcreteClass instance = new ConcreteClass();
            instance.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
