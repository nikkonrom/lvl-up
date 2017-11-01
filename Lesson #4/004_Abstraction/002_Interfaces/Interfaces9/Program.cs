using System;

// Наследование от интерфейсов у которых совпадают имена членов.

// Объединение реализации одноименных абстрактных членов.

namespace Interfaces
{
    interface IInterface1
    {
        void Method();
    }

    interface IInterface2
    {
        void Method();
    }

    class ConcreteClass : IInterface1, IInterface2
    {
        public void Method()
        {
            Console.WriteLine("Method - реализация интерфейса IInterface (1-2)");
        }
    }

    class Program
    {
        static void Main()
        {
            ConcreteClass instance = new ConcreteClass();
            instance.Method();

            IInterface1 instance1 = instance as IInterface1;
            instance1.Method();

            IInterface2 instance2 = instance as IInterface2;
            instance2.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
