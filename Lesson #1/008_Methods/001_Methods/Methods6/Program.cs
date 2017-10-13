using System;

// Возврат значений из метода Main ()

// Перегрузка метода Main () - допустима.

// Точкой входа в программу может быть метод Main (), который возвращает значение типа void или int.

namespace Methods
{
    class Program
    {
        
        // Перегрузка. (Не является точкой входа)
        static string Main(string argument)
        {
            return "Hello " + argument + "!";
        }

        
        // Точка входа в программу.
        static int Main()
        {
            string @string = Main("World");

            Console.WriteLine(@string);

            // Delay.
            Console.ReadKey();

            return 0;
        }
    }
}
