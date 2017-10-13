using System;

// Методы (Функции). 

namespace Methods
{
    class Program
    {
        /// <summary>
        /// Сложение двух целых чисел.
        /// </summary>
        /// <param name="summand1">Первое слагаемое</param>
        /// <param name="summand2">Второе слагаемое</param>
        /// <returns>Сумма</returns>
        static int Add(int summand1, int summand2)
        {
            return summand1 + summand2;
        }

        static void Main()
        {
            int summand1 = 2, summand2 = 3;

            int sum = Add(summand1, summand2);

            Console.WriteLine("{0} + {1} = {2}", summand1, summand2, sum);

            // Delay.
            Console.ReadKey();
        }
    }
}
