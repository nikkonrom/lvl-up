using System;

// Пример: Использование сторожевого оператора, для защиты номинального варианта.

namespace Methods
{
    class Program
    {
        static string Function(string name)
        {
            // Выполняем проверку. При обнаружении ошибок завершаем работу.

            if (name == "fool")   // Сторожевой оператор.
            {
                return "Вы использовали недопустимое слово.";
            }

            // Код номинального варианта.

            string sentence = "Hello " + name + "!";

            return sentence;
        }

        static void Main()
        {
            string sentence = Function("fool");

            Console.WriteLine(sentence);

            // Delay.
            Console.ReadKey();
        }
    }
}
