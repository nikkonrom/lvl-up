using System;

// Наследование интерфейса от интерфейса, у которых совпадают имена членов.

namespace Interfaces
{
    interface IInterface1
    {
        void Method();
    }

    interface IInterface2 : IInterface1
    {
        // Без new - ошибки не будет, но будет предупреждение компилятора.
        new void Method();
    }

    class ConcreteClass : IInterface2
    {
        void IInterface1.Method()
        {
            Console.WriteLine("Method - реализация интерфейса IInterface1");
        }

        void IInterface2.Method()
        {
            Console.WriteLine("Method - реализация интерфейса IInterface2");
        }
    }

    class Program
    {
        static void Main()
        {
            ConcreteClass instance = new ConcreteClass();
            //instance.Method();

            IInterface1 instance1 = instance as IInterface1;
            instance1.Method();

            IInterface2 instance2 = instance as IInterface2;
            instance2.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
