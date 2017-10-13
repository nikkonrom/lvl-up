using System;

// Методы (Функции).

namespace Methods
{
    class Program
    {
        // На 12-й строке, создаем метод с именем Function, который ничего не принимает и возвращает строковое значение.
        // В теле метода, используя ключевое слово return, возвращаем строку - Hello!

        static string Function()
        {
            return "Hello!";
        }

        static void Main()
        {
            // В теле метода Main на 22-й строке, создаем строковую локальную переменную с именем @string 
            // и присваиваем ей возвращаемое значение метода Function.

            string @string = Function();
                       
            Console.WriteLine(@string);

            // Delay.
            Console.ReadKey();
        }
    }
}
