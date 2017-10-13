using System;

// Рекурсия (простая рекурсия). 

// В теле метода Recursion на 19-й строке рекурсивно вызывается метод Recursion.
// Простая рекурсия -  вызов методом самого себя (самовызов). При каждом вызове строится новая копия метода.

namespace Methods
{
    class Program
    {
        static void Recursion(int counter)
        {
            counter--;

            Console.WriteLine("Первая половина метода: {0}", counter);

            if (counter != 0)
                Recursion(counter);

            Console.WriteLine("Вторая половина метода: {0}", counter);
        }

        static void Main()
        {
            Recursion(3);

            // Delay.
            Console.ReadKey();
        }
    }
}
