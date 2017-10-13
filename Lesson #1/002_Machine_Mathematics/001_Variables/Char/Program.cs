using System;

namespace Char
{
    class Program
    {
        static void Main()
        {
            char a = 'A';      // Символ
            char b = '\x0041'; // Значение в 16-ричном формате
            char c = '\u0041'; // Значение в формате unicode

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
