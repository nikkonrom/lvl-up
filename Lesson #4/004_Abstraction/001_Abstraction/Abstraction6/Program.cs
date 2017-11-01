using System;

namespace Abstraction
{
    abstract class AbstractClass
    {
        // Конструктор (отрабатывает первым).
        public AbstractClass()
        {
            Console.WriteLine("1 AbstractClass()");

            // Вызывается реализация метода из производного класса - ConcreteClass.
            this.AbstractMethod();

            Console.WriteLine("2 AbstractClass()");
        }

        public abstract void AbstractMethod();
    }

    class ConcreteClass : AbstractClass
    {
        string s = "FIRST";
        
        // Конструктор (отрабатывает вторым).
        public ConcreteClass()
        {
            Console.WriteLine("3 ConcreteClass()");
            s = "SECOND";
        }

        public override void AbstractMethod()
        {
            Console.WriteLine("Реализация метода AbstractMethod() в ConcreteClass  {0}", s);
        }
    }

    class Program
    {
        static void Main()
        {
            AbstractClass instance = new ConcreteClass();

            Console.WriteLine(new string('-', 55));

            instance.AbstractMethod();

            // Задержка.
            Console.ReadKey();
        }
    }
}
