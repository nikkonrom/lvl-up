using System;

// Самоассоциация (self-association).

namespace Classes
{
    class MyClass
    {
        MyClass instance;

        public MyClass()  // StackOverflowException
        {
            Console.WriteLine("Constructor MyClass");

            // Самоассоциация, после первой попытки инстанцирования приводит к цикличному инстанцированию.

            instance = new MyClass();
        }
    }

    class Program
    {
        static void Main()
        {
            // Попытка инстанцирования класса MyClass.

            MyClass instance = new MyClass();

            // Delay.
            Console.ReadKey();
        }
    }
}
