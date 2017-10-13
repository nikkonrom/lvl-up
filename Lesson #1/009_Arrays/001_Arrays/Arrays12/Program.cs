using System;

// Зубчатые массивы (Jagged Array).

namespace Arrays
{
    class Program
    {
        static void Main()
        {

            int[][] jagged = new[]
            {
               new int[] { 1, 2 },
               new int[] { 1, 2, 3, 4, 5 },
               new int[] { 1, 2, 3 }
            };

            // Во внешнем цикле выполняется проход по всем вложенным массивам.
            for (int i = 0; i < jagged.Length; ++i)
            {
                // Во внутреннем цикле выполняется обращение к каждому элементу вложенного массива.
                for (int j = 0; j < jagged[i].Length; ++j)
                {
                    Console.Write("{0} ", jagged[i][j]);
                }
                Console.Write("\n");
            }


            // Delay.
            Console.ReadKey();
        }
    }
}
