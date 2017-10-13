using System;

// Вывод в двоичном формате числа, переданного в десятичном формате

namespace BinaryDigit
{
    class Program
    {
        static void Converter(int n)
        {
            int temp;

            temp = n % 2;
            
            if (n >= 2)
                Converter(n / 2);

            Console.Write(temp);
        }

        static void Main()
        {
            int n = 69;

            Converter(n);

            Console.ReadKey();
        }
    }
}
