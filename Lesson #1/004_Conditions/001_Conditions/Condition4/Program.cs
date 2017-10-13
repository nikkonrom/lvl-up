using System;

// Условная конструкция - if-else (с несколькими ветвями). Каскад условных операторов.

namespace Condition
{
    class Program
    {
        static void Main()
        {
            int a = 1, b = 2;

            if (a < b)      // каскад условных операторов
            {
                Console.WriteLine("a < b");   // Ветвь 1
            }
            else if (a > b) // идем на новую проверку
            {
                Console.WriteLine("a > b");   // Ветвь 2
            }
            else 
            {
                Console.WriteLine("a == b");  // Ветвь 3
            }
            
            // Delay.
            Console.ReadKey();
        }
    }
}
