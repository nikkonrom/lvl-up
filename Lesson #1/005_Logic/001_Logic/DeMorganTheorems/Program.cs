using System;

/*
 * Преобразования логических переменных в соответствии с теоремами Де Моргана.
 * 
 * Для применения теорем Де Моргана к логическому оператору AND или OR и паре операндов, 
 * требуется инвертировать оба операнда, заменить (AND на OR) или (OR на AND) и 
 * инвертировать все выражение полностью.
 * 
 *  Исходное выражение              Эквивалентное выражение
 *     !A & !B                       =                  !(A | B)
 *     !A & B                        =                  !(A | !B)
 *     A & !B                        =                  !(!A | B)   
 *     A & B                         =                  !(!A | !B)
 *     !A | !B                       =                  !(A & B)
 *     !A | B                        =                  !(A & !B)
 *     A | !B                        =                  !(!A & B) 
 *     A | B                         =                  !(!A & !B)    
 */

namespace DeMorganTheorems
{
    class Program
    {
        static void Main()
        {
            bool A = true;
            bool B = false;

            // Условие до применения теоремы Де Моргана.
            if (!A || !B)
                Console.WriteLine("!A || !B = {0}", !A || !B);
            else
                Console.WriteLine("!A || !B = {0}", !A || !B);

            // Условие после применения теоремы Де Моргана.
            if (!(A && B))
                Console.WriteLine("!(A && B) = {0}", !(A && B));
            else
                Console.WriteLine("!(A && B) = {0}", !(A && B));

            // Delay.
            Console.ReadKey();
        }
    }
}
