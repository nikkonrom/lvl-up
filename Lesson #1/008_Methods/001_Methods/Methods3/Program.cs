using System;

// Именованные аргументы методов

namespace Methods
{
    class Program
    {
        static int Difference(int height, int width)
        {
            return height - width;
        }

        static void Main()
        {
            // Можно вызвать метод так:
            int difference = Difference(6, 5);

            //difference = Difference(5, 6);

            Console.WriteLine("Разность равна: {0}", difference);

            // А теперь, вот так:
            difference = Difference(width: 5, height: 6);

            Console.WriteLine("Разность равна: {0}", difference);

            Console.ReadKey();
        }
    }
}
