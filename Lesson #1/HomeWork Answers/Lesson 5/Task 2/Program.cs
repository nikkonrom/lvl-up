using System;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            int x = 5, y = 10, z = 15;

            Console.WriteLine("1-е уравнение = {0}", x += y >> x++ * z);
            Console.WriteLine("2-е уравнение = {0}", z = ++x & y * 5);
            Console.WriteLine("3-е уравнение = {0}", y /= x + 5 | z);
            Console.WriteLine("4-е уравнение = {0}", z = x++ & y * 5);
            Console.WriteLine("5-е уравнение = {0}", x = y << x++ ^ z);

            // Delay.
            Console.ReadKey();
        }
    }
}