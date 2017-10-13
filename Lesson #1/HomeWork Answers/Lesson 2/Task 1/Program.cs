using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            double pi = 3.141592653d;
            decimal e = 2.7182818284590452m;

            Console.Write("Число Pi равно: ");
            Console.WriteLine(pi);

            Console.Write("Число (Ейлера) e равно: ");
            Console.WriteLine(e);

            // Delay.
            Console.ReadKey();
        }
    }
}
