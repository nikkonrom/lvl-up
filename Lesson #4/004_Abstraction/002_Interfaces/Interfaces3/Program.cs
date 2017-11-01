using System;

// Явное указание имени интерфейса в имени метода.

namespace Interfaces
{
    class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass();

            //instance. -- // На экземпляре не видим методов интерфейсов.

            // Приведем экземпляр класса DerivedClass - instance, к базовому интерфейсному типу Interface1
            
            Interface1 instance1 = instance as Interface1;
            instance1.Method();

            Interface2 instance2 = instance as Interface2;
            instance2.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
