using System;

namespace Classes
{
    class MyClass1
    {
        public MyClass1()
        {
            Console.WriteLine("Создан экземпляр класса MyClass1");
        }
    }

    class MyClass2
    {
        private MyClass1 myObj = null;

        // Данный метод не является фабричным.
        public void Method()
        {
            myObj = new MyClass1();
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass2 my = new MyClass2();

            my.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
