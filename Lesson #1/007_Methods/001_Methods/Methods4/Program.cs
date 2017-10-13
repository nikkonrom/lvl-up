using System;

// Методы (Функции).

namespace Methods
{
    class Program
    {
        // На 13-й строке, создаем метод с именем Function, который принимает один строковой аргумент и возвращает строковое значение.
        // В теле метода, строковой локальной переменной sentence, присваиваем конкатенацию строк и аргумента, 
        // используя ключевое слово return, возвращаем значение переменной sentence.
        
        static string Function(string name)
        {
            string sentence = "Hello " + name + "!";

            return sentence;
        }

        static void Main()
        {
            // В теле метода Main на 25-й строке, создаем строковую локальную переменную с именем sentence, 
            // присваиваем ей возвращаемое значение метода Function, которому в качестве аргумента передаем строку - Alex.

            string sentence = Function("Alex");

            Console.WriteLine(sentence);

            // Delay.
            Console.ReadKey();
        }
    }
}
