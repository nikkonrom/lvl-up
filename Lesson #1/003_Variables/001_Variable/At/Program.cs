using System;

// Использование ключевых слов языка C# в качестве идентификаторов.

namespace At
{
    class Program
    {
        static void Main()
        {
            //int bool = 5;      // Illegal
            int @bool = 7;       // Legal
            Console.WriteLine(@bool);


            // Символ @ не является частью идентификатора, поэтому, @myVariable - это тоже самое, что и myVariable.
            string @myVariable = "Hello";
            Console.WriteLine(myVariable);


            // Delay.
            Console.ReadKey();
        }
    }
}
