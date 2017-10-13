using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12, z = 3;

            Console.WriteLine("1-е уравнение = {0}", x += y - x++ * z);

            x = 10;
            y = 12;
            z = 3;
            Console.WriteLine("2-е уравнение = {0}", z = --x - y * 5);

            x = 10;
            y = 12;
            z = 3;
            Console.WriteLine("3-е уравнение = {0}", y /= x + 5 % z);

            x = 10;
            y = 12;
            z = 3;
            Console.WriteLine("4-е уравнение = {0}", z = x++ + y * 5);

            x = 10;
            y = 12;
            z = 3;
            Console.WriteLine("5-е уравнение = {0}", x = y - x++ * z);

            // Delay.
            Console.ReadKey();
        }
    }
}
