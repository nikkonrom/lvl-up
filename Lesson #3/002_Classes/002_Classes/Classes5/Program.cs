using System;

// Самоассоциация (self-association).

namespace Classes
{
    class Program
    {
        public void Method()
        {
            Console.WriteLine("Hello world!");
        }

        static void Main()
        {
            Program program = new Program();
           
            program.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
