using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            string a = "\nмоя строка 1";
            string b = "\tмоя строка 2";
            string c = "\aмоя строка 3";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            // Delay.
            Console.ReadKey();
        }
    }
}
