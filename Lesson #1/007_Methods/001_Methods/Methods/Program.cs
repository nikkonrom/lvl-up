using System;

// Методы (Процедуры).

namespace Methods
{
    class Program
    {
        // На 12-й строке, создаем метод с именем Procedure, который ничего не принимает и ничего не возвращает.
        // В теле метода, на 14-й строке выводим на экран строку - Hello!        

        static void Procedure()
        {
            Console.WriteLine("Hello!");
        }

        static void Main()
        {
            // В теле метода Main на 21-й строке, вызываем метод Procedure.

            Procedure();

            // Delay.
            Console.ReadKey();
        }
    }
}
