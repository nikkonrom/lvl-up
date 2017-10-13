using System;

// Сцепление строк. (Конкатенация)

namespace Concatenation
{
    class Program
    {
        static void Main()
        {
            // 1 вариант.
            string word1 = "Привет ";
            string word2 = "Мир!";            
            string phrase = word1 + word2;
            Console.WriteLine(phrase);
            
            // 2 вариант.
            Console.WriteLine("Hello " + "World!");

            // Delay.
            Console.ReadKey();
        }
    }
}
